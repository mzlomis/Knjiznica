<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs" Inherits="UK.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            text-align: center;
        }
        .auto-style1 {
            width: 1272px;
            height: 30px;
            position: absolute;
            left: 10px;
            top: 76px;
            z-index: 1;
        }
        .auto-style2 {
            text-align: left;
            background-color: #FFFF66;
        }
        .auto-style3 {
            font-weight: bold;
        }
    </style>
</head>
<body style="height: 42px; width: 1272px">
        <div style="text-align: center; font-size: xx-large; font-family: 'Courier New', Courier, monospace; text-decoration: underline">
            REGISTRACIJA KORISNIKA</div>
    <form id="form1" runat="server" class="auto-style1">
        <div class="auto-style2">
            <asp:Label ID="LblOIB" runat="server" CssClass="auto-style3" style="position: relative; text-align: left" Text="OIB"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtOIB" runat="server" style="margin-left: 10px" Width="217px"></asp:TextBox>
            <p class="auto-style2">
                <asp:Label ID="LblIme" runat="server" CssClass="auto-style3" style="position: relative" Text="Ime"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TxtIme" runat="server" style="margin-left: 35px" Width="217px"></asp:TextBox>
&nbsp;</p>
            <p class="auto-style2">
                <asp:Label ID="LblPrezime" runat="server" CssClass="auto-style3" style="position: relative" Text="Prezime"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TxtPrezime" runat="server" style="margin-left: 10px" Width="217px"></asp:TextBox>
            </p>
            <p class="auto-style2">
                <asp:Label ID="LblAdresa" runat="server" CssClass="auto-style3" style="position: relative" Text="Adresa"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TxtAdresa" runat="server" style="margin-left: 10px" Width="217px"></asp:TextBox>
            </p>
            <p class="auto-style2">
                <asp:Label ID="LblPostanskiBroj" runat="server" CssClass="auto-style3" style="position: relative" Text="Postanski Broj"></asp:Label>
&nbsp;<asp:TextBox ID="TxtPostnskiBroj" runat="server" style="margin-left: 35px" Width="217px"></asp:TextBox>
            </p>
            <p class="auto-style2">
                <asp:Label ID="LblGrad" runat="server" CssClass="auto-style3" style="position: relative" Text="Grad"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TxtGrad" runat="server" style="margin-left: 35px" Width="217px"></asp:TextBox>
            </p>
            <p class="auto-style2">
                <asp:Label ID="LblKorisnicko_ime" runat="server" CssClass="auto-style3" style="position: relative" Text="Korisnicko Ime"></asp:Label>
&nbsp;<asp:TextBox ID="TxtKorIme" runat="server" style="margin-left: 35px" Width="217px"></asp:TextBox>
            </p>
            <p class="auto-style2">
                <asp:Label ID="LblLoz" runat="server" CssClass="auto-style3" style="position: relative" Text="Lozinka"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TxtLoz" runat="server" style="margin-left: 35px" Width="217px"></asp:TextBox>
            </p>
        </div>
        <p class="auto-style2">
            <asp:Button ID="BtnRegistracija" runat="server" OnClick="BtnRegistracija_Click" style="text-align: left" Text="Registriraj se" Width="392px" />
        </p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" Width="1270px" OnRowUpdating="GridView1_RowUpdating" AllowSorting="True" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
    </form>
</body>
</html>
