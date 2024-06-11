using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FINAL01.ViewModel;

namespace FINAL01.View
{
    /// <summary>
    /// Interaction logic for CreateCar.xaml
    /// </summary>
    public partial class CreateCar : Page
    {
        public CreateCar()
        {
            InitializeComponent();
            this.DataContext = new CarViewModel ();
        }

       

        private void TextBox_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            if (sender is TextBox textBox && textBox.Text == (string)textBox.Tag)
            {
                textBox.Text = "";
                textBox.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Black);
            }
        }

        private void TextBox_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            if (sender is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = (string)textBox.Tag;
                textBox.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.LightGray);
            }
        }
    }
}
