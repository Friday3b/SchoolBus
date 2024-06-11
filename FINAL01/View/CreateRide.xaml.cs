using FINAL01.ViewModel;
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Interaction logic for CreateRide.xaml
    /// </summary>
    public partial class CreateRide : Page
    {
        private DriverViewModel _viewModel;
        private ClassViewModel _classViewModel;

        public CreateRide()
        {
            InitializeComponent();
            _viewModel = new DriverViewModel();
            _classViewModel = new ClassViewModel();
            Driver_combobox.DataContext = _viewModel;
            Student_combobox.DataContext = _classViewModel;
            Student_combobox_assemblypoint.DataContext = _classViewModel;
            mp.Center = new Location(40.403665, 49.807948);
            mp.ZoomLevel = 15;

            //burada ashaqidaki kimi vermedim cunki sistem error verirdi // sebebi ise config file idi //
            //Creds = new ApplicationIdCredentialsProvider(ConfigurationManager.AppSettings["ApiKey"]);


        }

        public ApplicationIdCredentialsProvider Creds { get; set; }


        public Map GetMapControl()
        {
            return mp;
        }

        public void AddPushpin(double latitude, double longitude, string tooltip = "")
        {
            var location = new Location(latitude, longitude);
            var pushpin = new Pushpin
            {
                Location = location,
                ToolTip = tooltip
            };
            mp.Children.Add(pushpin);
            mp.Center = location;
            mp.ZoomLevel = 15;
        }


    }
}
