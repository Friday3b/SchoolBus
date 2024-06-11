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
using System.Collections.ObjectModel;
using System.ComponentModel;
using FINAL01.ViewModel;
using FINAL01.Command;
using FINAL01.Model;
using FINAL01.View;


namespace FINAL01.View
{
    /// <summary>
    /// Interaction logic for CreateStudent.xaml
    /// </summary>
    //public partial class CreateStudent : Page
    //{
    //    public CreateStudent()
    //    {
    //        InitializeComponent();
    //        StudentViewModel viewModel = new StudentViewModel();
    //        this.DataContext = viewModel;



    //    }
    //    //firstname section 
    //    private void TextBox_GotFocus(object sender, RoutedEventArgs e)
    //    {

    //        TextBox? textBox = sender as TextBox;
    //        if (firstname_of_textbox.Text == "FirstName")
    //        {
    //            firstname_of_textbox.Text = "";
    //            firstname_of_textbox.Foreground = new SolidColorBrush(Colors.Black);
    //        }

    //    }

    //    private void TextBox_LostFocus(object sender, RoutedEventArgs e)
    //    {
    //        TextBox? textBox = sender as TextBox;
    //        if (string.IsNullOrWhiteSpace(firstname_of_textbox.Text))
    //        {
    //            firstname_of_textbox.Text = "FirstName";
    //            firstname_of_textbox.Foreground = new SolidColorBrush(Colors.Gray);
    //        }
    //    }
    //    // last name section 
    //    private void lastname_of_textbox_GotFocus(object sender, RoutedEventArgs e)
    //    {
    //        TextBox? textBox1 = sender as TextBox;
    //        if (lastname_of_textbox.Text == "LastName")
    //        {
    //            lastname_of_textbox.Text = "";
    //            lastname_of_textbox.Foreground = new SolidColorBrush(Colors.Black);
    //        }

    //    }

    //    private void lastname_of_textbox_LostFocus(object sender, RoutedEventArgs e)
    //    {
    //        TextBox? textBox1 = sender as TextBox;
    //        if (string.IsNullOrWhiteSpace(lastname_of_textbox.Text))
    //        {
    //            lastname_of_textbox.Text = "LastName";
    //            lastname_of_textbox.Foreground = new SolidColorBrush(Colors.Gray);
    //        }

    //    }

    //    private void parent_of_textbox_GotFocus(object sender, RoutedEventArgs e)
    //    {
    //        TextBox? textBox2 = sender as TextBox;
    //        if (parent_of_textbox.Text == "Parent")
    //        {
    //            parent_of_textbox.Text = "";
    //            parent_of_textbox.Foreground = new SolidColorBrush(Colors.Black);
    //        }
    //    }

    //    private void parent_of_textbox_LostFocus(object sender, RoutedEventArgs e)
    //    {

    //        TextBox? textBox2 = sender as TextBox;
    //        if (string.IsNullOrWhiteSpace(parent_of_textbox.Text))
    //        {
    //            parent_of_textbox.Text = "Parent";
    //            parent_of_textbox.Foreground = new SolidColorBrush(Colors.Gray);
    //        }
    //    }

    //    private void homeadres_of_textbox_GotFocus(object sender, RoutedEventArgs e)
    //    {
    //        TextBox? textBox3 = sender as TextBox;
    //        if (homeaddress_of_textbox.Text == "Home address")
    //        {
    //            homeaddress_of_textbox.Text = "";
    //            homeaddress_of_textbox.Foreground = new SolidColorBrush(Colors.Black);
    //        }
    //    }

    //    private void homeadres_of_textbox_LostFocus(object sender, RoutedEventArgs e)
    //    {
    //        TextBox? textBox3 = sender as TextBox;
    //        if (string.IsNullOrWhiteSpace(homeaddress_of_textbox.Text))
    //        {
    //            homeaddress_of_textbox.Text = "Home address";
    //            homeaddress_of_textbox.Foreground = new SolidColorBrush(Colors.Gray);
    //        }
    //    }

    //    private void otheraddress_of_textbox_GotFocus(object sender, RoutedEventArgs e)
    //    {
    //        TextBox? textBox4 = sender as TextBox;
    //        if (otheraddress_of_textbox.Text == "Other address")
    //        {
    //            otheraddress_of_textbox.Text = "";
    //            otheraddress_of_textbox.Foreground = new SolidColorBrush(Colors.Black);
    //        }
    //    }

    //    private void otheraddress_of_textbox_LostFocus(object sender, RoutedEventArgs e)
    //    {
    //        TextBox? textBox4 = sender as TextBox;
    //        if (string.IsNullOrWhiteSpace(otheraddress_of_textbox.Text))
    //        {
    //            otheraddress_of_textbox.Text = "Other address";
    //            otheraddress_of_textbox.Foreground = new SolidColorBrush(Colors.Gray);
    //        }
    //    }
    //}


    public partial class CreateStudent : Page
    {
        public CreateStudent()
        {
            InitializeComponent();
            DataContext = new StudentViewModel();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "FirstName")
            {
                textBox.Text = "";
                textBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "FirstName";
                textBox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void lastname_of_textbox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "LastName")
            {
                textBox.Text = "";
                textBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void lastname_of_textbox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "LastName";
                textBox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void parent_of_textbox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Parent")
            {
                textBox.Text = "";
                textBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void parent_of_textbox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Parent";
                textBox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void homeadres_of_textbox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "HomeAddress")
            {
                textBox.Text = "";
                textBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void homeadres_of_textbox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "HomeAddress";
                textBox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void otheraddress_of_textbox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "OtherAddress")
            {
                textBox.Text = "";
                textBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void otheraddress_of_textbox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "OtherAddress";
                textBox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }
    }
}
