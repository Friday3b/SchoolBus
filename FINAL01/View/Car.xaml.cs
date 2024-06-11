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
using FINAL01.Model;

namespace FINAL01.View
{
    /// <summary>
    /// Interaction logic for Car.xaml
    /// </summary>
    public partial class Car : Page
    {
        private CarViewModel _viewModel;

        public Car()
        {
            InitializeComponent();
            _viewModel = new CarViewModel();
            this.DataContext = _viewModel;
        }

        private void create_button_parent_Click(object sender, RoutedEventArgs e)
        {
            CreateCar createCar = new CreateCar();
            this.NavigationService.Navigate(createCar);
        }
    }
}
