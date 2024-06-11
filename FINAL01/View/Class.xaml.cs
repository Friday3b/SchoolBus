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
    /// Interaction logic for Class.xaml
    /// </summary>
    public partial class Class : Page
    {
        private ClassViewModel _viewModel;

        public Class()
        {
            InitializeComponent();
            _viewModel = new ClassViewModel();
            this.DataContext = _viewModel;
        }

        private void create_button_class_Click(object sender, RoutedEventArgs e)
        {
            CreateClass createClass = new CreateClass();
            this.NavigationService.Navigate(createClass);
        }
    }
}
