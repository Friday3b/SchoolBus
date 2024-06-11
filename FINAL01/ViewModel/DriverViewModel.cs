using FINAL01.Command;
using FINAL01.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using System.ComponentModel;
using FINAL01.Command;
using FINAL01.Model;

namespace FINAL01.ViewModel
{
    public class DriverViewModel : INotifyPropertyChanged

    {

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
        private readonly DriverService _driverService;

        public DriverViewModel()
        {
            _driverService = new DriverService();
            LoadData();
            CurrentDriver = new Driver();
            SaveCommand = new RelayCommand(Save);
            SearchCommand = new RelayCommand(Search);
        }

        private ObservableCollection<Driver> _driverList;
        public ObservableCollection<Driver> DriverList
        {
            get { return _driverList; }
            set { _driverList = value; OnPropertyChanged(); }
        }

        private void LoadData()
        {
            DriverList = new ObservableCollection<Driver>(_driverService.GetAll());
        }

        private Driver _currentDriver;
        public Driver CurrentDriver
        {
            get { return _currentDriver; }
            set { _currentDriver = value; OnPropertyChanged(); }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; OnPropertyChanged(); }
        }

        public RelayCommand SaveCommand { get; }
        public RelayCommand SearchCommand { get; }

        public void Save()
        {
            try
            {
                var isSaved = _driverService.Add(CurrentDriver);
                if (isSaved)
                {
                    LoadData();
                    Message = "Driver saved";
                    MessageBox.Show("Driver saved");
                }
                else
                {
                    Message = "Save operation failed";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }

        public void Search()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CurrentDriver.FirstName))
                {
                    LoadData();
                    MessageBox.Show("All driver is here ");
                }
                //burada butun driverlar search commandasinda emnpty olaraq search etsek cixacaq deye etdim ...

                else {
                    var driver = _driverService.Search(CurrentDriver.FirstName);
                    if (driver != null)
                    {
                        CurrentDriver = driver;
                        DriverList.Clear();
                        DriverList.Add(driver);
                        MessageBox.Show("Driver found");
                    }
                    else
                    {
                        Message = "Driver not found";
                        MessageBox.Show("Driver not found");
                    }
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
