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
    /// Interaction logic for Parent.xaml
    /// </summary>
    //public partial class Parent : Page
    //{
    //    public Parent()
    //    {
    //        InitializeComponent();
    //    }

    //    private void create_button_parent_Click(object sender, RoutedEventArgs e)
    //    {
    //        CreateParent createparent = new CreateParent();
    //        this.NavigationService.Navigate(createparent);
    //    }

    //    private void search_button_parent_Click(object sender, RoutedEventArgs e)
    //    {

    //    }

    //}


    public partial class Parent : Page
    {
        private ParentViewModel _viewModel;

        public Parent()
        {
            InitializeComponent();
            _viewModel = new ParentViewModel();
            this.DataContext = _viewModel;
        }

        private void create_button_parent_Click(object sender, RoutedEventArgs e)
        {
            CreateParent createparent = new CreateParent();
            this.NavigationService.Navigate(createparent);
        }
    }
}
