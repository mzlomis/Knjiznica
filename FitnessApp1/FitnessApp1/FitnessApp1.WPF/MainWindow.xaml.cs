using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace FitnessApp1.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();

            // Xamarin Form Call
            Forms.Init();
            LoadApplication(new App3.App());
        }
    }
}
