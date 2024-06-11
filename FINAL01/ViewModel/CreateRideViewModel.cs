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
using System.Windows.Input;

namespace FINAL01.ViewModel
{
    class CreateRideViewModel : INotifyPropertyChanged
    {

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


        private readonly CreateRideService _createrideService;

        public CreateRideViewModel()
        {
            _createrideService = new CreateRideService();
            LoadData();
            CurrentCreateRide = new CreateRide();
            SaveCommand = new RelayCommand(Save);
            //SearchCommand = new RelayCommand(Search);
        }

        private ObservableCollection<CreateRide> _createrideList;
        public ObservableCollection<CreateRide> CreateRideList
        {
            get { return _createrideList; }
            set { _createrideList = value; OnPropertyChanged(); }
        }

        private void LoadData()
        {
            CreateRideList = new ObservableCollection<CreateRide>(_createrideService.GetAll());
        }

        private CreateRide _currentCreateRide;
        public CreateRide CurrentCreateRide
        {
            get { return _currentCreateRide; }
            set { _currentCreateRide = value; OnPropertyChanged(); }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; OnPropertyChanged(); }
        }

        public RelayCommand SaveCommand { get; }

        //public RelayCommand SearchCommand { get; }

        public void Save()
        {
            try
            {
                var isSaved = _createrideService.Add(CurrentCreateRide);
                if (isSaved)
                {
                    LoadData();
                    Message = "CreateRide saved";
                    MessageBox.Show("CreateRide saved");
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
    }





    //class CreateRideViewModel : INotifyPropertyChanged
    //{
    //    #region INotifyPropertyChanged
    //    public event PropertyChangedEventHandler? PropertyChanged;
    //    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }
    //    #endregion

    //    private readonly CreateRideService _createrideService;

    //    public CreateRideViewModel()
    //    {
    //        _createrideService = new CreateRideService();
    //        LoadData();
    //        CurrentCreateRide = new CreateRide();
    //        SaveCommand = new RelayCommand(Save);
    //        StartCommand = new RelayCommand(StartJourney);
    //    }

    //    private ObservableCollection<CreateRide> _createrideList;
    //    public ObservableCollection<CreateRide> CreateRideList
    //    {
    //        get { return _createrideList; }
    //        set { _createrideList = value; OnPropertyChanged(); }
    //    }

    //    private void LoadData()
    //    {
    //        CreateRideList = new ObservableCollection<CreateRide>(_createrideService.GetAll());
    //    }

    //    private CreateRide _currentCreateRide;
    //    public CreateRide CurrentCreateRide
    //    {
    //        get { return _currentCreateRide; }
    //        set { _currentCreateRide = value; OnPropertyChanged(); }
    //    }

    //    private string _message;
    //    public string Message
    //    {
    //        get { return _message; }
    //        set { _message = value; OnPropertyChanged(); }
    //    }

    //    public RelayCommand SaveCommand { get; }
    //    public RelayCommand StartCommand { get; }

    //    public void Save()
    //    {
    //        try
    //        {
    //            var isSaved = _createrideService.Add(CurrentCreateRide);
    //            if (isSaved)
    //            {
    //                LoadData();
    //                Message = "CreateRide saved";
    //                MessageBox.Show("CreateRide saved");
    //            }
    //            else
    //            {
    //                Message = "Save operation failed";
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Message = ex.Message;
    //        }
    //    }

    //    public void StartJourney()
    //    {
    //        string startLocation = CurrentCreateRide.Locations;
    //        string endLocation = "School"; // Define the school location
    //        string url = GenerateGoogleMapsUrl(startLocation, endLocation);

    //        // Raise an event or update a property to notify the view
    //        MapUrl = url;
    //    }

    //    private string _mapUrl;
    //    public string MapUrl
    //    {
    //        get { return _mapUrl; }
    //        set { _mapUrl = value; OnPropertyChanged(); }
    //    }

    //    private string GenerateGoogleMapsUrl(string start, string end)
    //    {
    //        return $"https://www.google.com/maps/dir/{Uri.EscapeDataString(start)}/{Uri.EscapeDataString(end)}";
    //    }
    //}

}