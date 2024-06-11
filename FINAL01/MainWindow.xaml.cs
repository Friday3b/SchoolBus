using Microsoft.Maps.MapControl.WPF.Core;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FINAL01.View;

namespace FINAL01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CredentialsProvider Creds { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        private void CreateRide(object sender, RoutedEventArgs e)
        {
            Main.Content = new FINAL01.View.CreateRide();
        }

        

        private void Class(object sender, RoutedEventArgs e)
        {
            Main.Content = new FINAL01.View.Class();
        }

        private void Student(object sender, RoutedEventArgs e)
        {
            Main.Content = new FINAL01.View.Student();
        }

        private void Parent_button(object sender, RoutedEventArgs e)
        {
            Main.Content = new FINAL01.View.Parent(); 
        }

        private void Driver_click(object sender, RoutedEventArgs e)
        {
            Main.Content = new FINAL01.View.Driver();
        }

        private void Car_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new FINAL01.View.Car();
        }

        private void Holiday(object sender, RoutedEventArgs e)
        {
            Main.Content = new FINAL01.View.Holiday();
        }


        private void CreateRide1(object sender, RoutedEventArgs e)
        {
            var createRidePage = new CreateRide();
            Main.Content = createRidePage;

            // CreateRide sayfasındaki Map kontrolüne erişim
            var mapControl = createRidePage.GetMapControl();

            
            createRidePage.AddPushpin(47.6062, -122.3321, "Seattle");
        }



    }
}