using FINAL01.ViewModel;
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

namespace FINAL01.View
{
    /// <summary>
    /// Interaction logic for CreateParent.xaml
    /// </summary>
    //public partial class CreateParent : Page
    //{
    //    public CreateParent()
    //    {
    //        InitializeComponent();
    //    }



    //    private void firstname_of_textbox_GotFocus(object sender, RoutedEventArgs e)
    //    {
    //        TextBox? textBox = sender as TextBox;
    //        if (firstname_of_textbox.Text == "FirstName")
    //        {
    //            firstname_of_textbox.Text = "";
    //            firstname_of_textbox.Foreground = new SolidColorBrush(Colors.Black);
    //        }
    //    }

    //    private void firstname_of_textbox_LostFocus(object sender, RoutedEventArgs e)
    //    {
    //        TextBox? textBox = sender as TextBox;
    //        if (string.IsNullOrWhiteSpace(firstname_of_textbox.Text))
    //        {
    //            firstname_of_textbox.Text = "FirstName";
    //            firstname_of_textbox.Foreground = new SolidColorBrush(Colors.Gray);
    //        }
    //    }

    //    private void lastname_of_textbox_GotFocus(object sender, RoutedEventArgs e)
    //    {
    //        TextBox? textBox = sender as TextBox;
    //        if (lastname_of_textbox.Text == "LastName")
    //        {
    //            lastname_of_textbox.Text = "";
    //            lastname_of_textbox.Foreground = new SolidColorBrush(Colors.Black);
    //        }
    //    }

    //    private void lastname_of_textbox_LostFocus(object sender, RoutedEventArgs e)
    //    {
    //        TextBox? textBox = sender as TextBox;
    //        if (string.IsNullOrWhiteSpace(lastname_of_textbox.Text))
    //        {
    //            lastname_of_textbox.Text = "LastName";
    //            lastname_of_textbox.Foreground = new SolidColorBrush(Colors.Gray);
    //        }
    //    }

    //    private void phone_of_textbox_GotFocus(object sender, RoutedEventArgs e)
    //    {
    //        TextBox? textBox = sender as TextBox;
    //        if (phone_of_textbox.Text == "Phone")
    //        {
    //            phone_of_textbox.Text = "";
    //            phone_of_textbox.Foreground = new SolidColorBrush(Colors.Black);
    //        }
    //    }

    //    private void phone_of_textbox_LostFocus(object sender, RoutedEventArgs e)
    //    {
    //        TextBox? textBox = sender as TextBox;
    //        if (string.IsNullOrWhiteSpace(phone_of_textbox.Text))
    //        {
    //            phone_of_textbox.Text = "Phone";
    //            phone_of_textbox.Foreground = new SolidColorBrush(Colors.Gray);
    //        }
    //    }

    //    private void username_of_textbox_GotFocus(object sender, RoutedEventArgs e)
    //    {
    //        TextBox? textBox = sender as TextBox;
    //        if (username_of_textbox.Text == "Username")
    //        {
    //            username_of_textbox.Text = "";
    //            username_of_textbox.Foreground = new SolidColorBrush(Colors.Black);
    //        }
    //    }

    //    private void username_of_textbox_LostFocus(object sender, RoutedEventArgs e)
    //    {
    //        TextBox? textBox = sender as TextBox;
    //        if (string.IsNullOrWhiteSpace(username_of_textbox.Text))
    //        {
    //            username_of_textbox.Text = "Username";
    //            username_of_textbox.Foreground = new SolidColorBrush(Colors.Gray);
    //        }
    //    }

    //    private void password_of_textbox_GotFocus(object sender, RoutedEventArgs e)
    //    {
    //        TextBox? textBox = sender as TextBox;
    //        if (password_of_textbox.Text == "Password")
    //        {
    //            password_of_textbox.Text = "";
    //            password_of_textbox.Foreground = new SolidColorBrush(Colors.Black);
    //        }
    //    }

    //    private void password_of_textbox_LostFocus(object sender, RoutedEventArgs e)
    //    {
    //        TextBox? textBox = sender as TextBox;
    //        if (string.IsNullOrWhiteSpace(password_of_textbox.Text))
    //        {
    //            password_of_textbox.Text = "Password";
    //            password_of_textbox.Foreground = new SolidColorBrush(Colors.Gray);
    //        }
    //    }
    //}

    public partial class CreateParent : Page
    {
        public CreateParent()
        {
            InitializeComponent();
            this.DataContext = new ParentViewModel();
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
