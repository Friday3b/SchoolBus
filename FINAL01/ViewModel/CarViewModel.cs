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

namespace FINAL01.ViewModel
{
    public class CarViewModel : INotifyPropertyChanged

    {

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
        private readonly CarService _carService;

        public CarViewModel()
        {
            _carService = new CarService();
            LoadData();
            CurrentCar = new Car();
            SaveCommand = new RelayCommand(Save);
            SearchCommand = new RelayCommand(Search);
        }

        private ObservableCollection<Car> _carList;
        public ObservableCollection<Car> CarList
        {
            get { return _carList; }
            set { _carList = value; OnPropertyChanged(); }
        }

        private void LoadData()
        {
            CarList = new ObservableCollection<Car>(_carService.GetAll());
        }

        private Car _currentCar;
        public Car CurrentCar
        {
            get { return _currentCar; }
            set { _currentCar = value; OnPropertyChanged(); }
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
                var isSaved = _carService.Add(CurrentCar);
                if (isSaved)
                {
                    LoadData();
                    Message = "Car saved";
                    MessageBox.Show("Car saved");
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
                if (string.IsNullOrWhiteSpace(CurrentCar.Name))
                {
                    LoadData();
                    MessageBox.Show("All car is here ");
                }
                //burada butun car search commandasinda emnpty olaraq search etsek cixacaq deye etdim ...

                else
                {
                    var car = _carService.Search(CurrentCar.Name);
                    if (car != null)
                    {
                        CurrentCar = car;
                        CarList.Clear();
                        CarList.Add(car);
                        MessageBox.Show("Car found");
                    }
                    else
                    {
                        Message = "Car not found";
                        MessageBox.Show("Car not found");
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
