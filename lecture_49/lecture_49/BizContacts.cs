using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//needed for file use

namespace lecture_49
{
    public partial class BizContacts : Form
    {
        string connString = @"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=AdresBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter dataAdapter;//this objct here allows us to build a connection between the program and th database
        DataTable table;//table to hold the information so we can fill the data grid view
        SqlConnection conn;//declares a variable to hold the sql connection
        string selectionStatement = "Select * from BizContacts";


        public BizContacts()
        {
            InitializeComponent();
        }

        private void BizContacts_Load(object sender, EventArgs e)
        {
            cboSearch.SelectedIndex = 0;//First item in teh combobox is selected when the form loads
            dataGridView1.DataSource = bindingSource1;//sets the source of the data to be displayed in the grid view
            //line below calls a method called Get Data
            //The argument is a string that represents an sql query
            //select * from BizContacts means select all the data from the bizcontacts table
            GetData(selectionStatement);
        }

        private void GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, connString);//pass in the select command and the connection string
                table = new DataTable();//make a new data table object
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);//fill the data table
                bindingSource1.DataSource = table;//set the data source on the binding source of the table
                dataGridView1.Columns[0].ReadOnly = true;//this helps prevent the id field from being changed
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);//show a useful message to the user of the program
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command;//declares a new sql command object
            //field names in the table
            string insert = @"insert into BizContacts(Date_Added, Company, Website, Title, First_Name, Last_Name, Adress,
                                                    City, Postal_Code, Mobile, Notes, Image)
                            values(@Date_Added, @Company, @Website, @Title, @First_Name, @Last_Name, @Adress,
                                                    @City, @Postal_Code, @Mobile, @Notes, @Image)";//parameter names

            using (conn = new SqlConnection(connString))//using allows disposing of low level recources
            {
                try
                {
                    conn.Open();//open the connection
                    command = new SqlCommand(insert, conn);//create the new sql command object
                    command.Parameters.AddWithValue(@"Date_Added", dateTimePicker1.Value.Date);//read value from form and save to table
                    command.Parameters.AddWithValue(@"Company", txtCompany.Text);//read value from form and save to table
                    command.Parameters.AddWithValue(@"Website", txtWebsite.Text);//read value from form and save to table
                    command.Parameters.AddWithValue(@"Title", txtTitle.Text);//read value from form and save to table
                    command.Parameters.AddWithValue(@"First_Name", txtFName.Text);//read value from form and save to 
                    command.Parameters.AddWithValue(@"Last_Name", txtLName.Text);//read value from form and save to table
                    command.Parameters.AddWithValue(@"Adress", txtAddress.Text);//read value from form and save to table
                    command.Parameters.AddWithValue(@"City", txtCity.Text);//read value from form and save to table
                    command.Parameters.AddWithValue(@"Postal_Code", txtPostalCode.Text);//read value from form and save to table
                    command.Parameters.AddWithValue(@"Mobile", txtMobile.Text);//read value from form and save to table
                    command.Parameters.AddWithValue(@"Notes", txtNotes.Text);//read value from form and save to table
                    if (dlgOpenImage.FileName != "")//check whether file name is not empty
                        command.Parameters.AddWithValue(@"Image", File.ReadAllBytes(dlgOpenImage.FileName));//convert imges to bytes for saving
                    else
                        command.Parameters.Add("@Image", SqlDbType.VarBinary).Value = DBNull.Value;//save null to database
                    command.ExecuteNonQuery();//push stuff into the table
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//if there is something wrong, show the user  message
                }
            }
            GetData(selectionStatement);
            dataGridView1.Update();//redraws the data grid view so the new record is visible on the bottom

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();//get the update command
            try
            {
                bindingSource1.EndEdit();//updates the table that is in memory of our program
                dataAdapter.Update(table);//actually updates the data base
                MessageBox.Show("Updat succesfull");//confirms to user the update is saved in the sql data base
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//Show message to the user
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;//grab a refrence to the current row
            string value = row.Cells["ID"].Value.ToString();//grab the value from the ID field of the selected record
            string fname = row.Cells["First_Name"].Value.ToString();//grab the value from the first name field of the selected record
            string lname = row.Cells["Last_Name"].Value.ToString();//grab the value from the Last name field of the selected record
            DialogResult result = MessageBox.Show("Do You relly want to delete" + fname + " " + lname + " record" + value, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            string deleteState = @"Delete from BizContacts where id = '" + value + "'";//this is the sql to delete the records from the sql table

            if (result == DialogResult.Yes) ;//check whether the user really wants to delete the record
            {
                using (conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();//try to open connection
                        SqlCommand comm = new SqlCommand(deleteState, conn);
                        comm.ExecuteNonQuery();// ths actually causes the deletion to run
                        GetData(selectionStatement);//get the data again
                        dataGridView1.Update();//redraw the data grid view with updated information
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);//runs when something is wrong with the connection
                    }
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cboSearch.SelectedItem.ToString())//present because we have a combo box
            {
                case "First Name":
                    GetData("select * from bizcontacts where lower(first_name) like '%" + txtSearch.Text.ToLower() + "%'");
                    break;
                case "Last Name":
                    GetData("select * from bizcontacts where lower(last_name) like '%" + txtSearch.Text.ToLower() + "%'");
                    break;
                case "Company":
                    GetData("select * from bizcontacts where lower(company) like '%" + txtSearch.Text.ToLower() + "%'");
                    break;

            }
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Data isn't entered");
            }
        }

        private void btnGetImage_Click(object sender, EventArgs e)
        {
            if(dlgOpenImage.ShowDialog()==DialogResult.OK);//use if in case user cancels getting image and the filename is blank
            pictureBox1.Load(dlgOpenImage.FileName);//loads image from drive using file name propert of the dialog box
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new Form();//make a new form
            frm.BackgroundImage = pictureBox1.Image;//set background image of new, priview form of image
            frm.Size = pictureBox1.Image.Size;//sets the size of the form to the size of the image, so the image is wholly visible
            frm.Show();//show form with image
        }
    }
}
