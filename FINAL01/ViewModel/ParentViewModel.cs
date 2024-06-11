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
    //public class ParentViewModel : INotifyPropertyChanged
    //{
    //    public event PropertyChangedEventHandler? PropertyChanged;
    //    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }



    //    private ParentService _parentService;

    //    public ParentViewModel()
    //    {
    //        _parentService = new ParentService();
    //        LoadData();
    //        CurrentParent = new Parent();
    //        SaveCommand = new RelayCommand(Save);
    //        SearchCommand = new RelayCommand(Search);
    //    }

    //    private ObservableCollection<Parent> _parentList;
    //    public ObservableCollection<Parent> ParentList
    //    {
    //        get { return _parentList; }
    //        set { _parentList = value; OnPropertyChanged(); }
    //    }

    //    private void LoadData()
    //    {
    //        ParentList = new ObservableCollection<Parent>(_parentService.GetAll());
    //    }

    //    private Parent _currentParent;
    //    public Parent CurrentParent
    //    {
    //        get { return _currentParent; }
    //        set { _currentParent = value; OnPropertyChanged(); }
    //    }

    //    private string _message;
    //    public string Message
    //    {
    //        get { return _message; }
    //        set { _message = value; OnPropertyChanged(); }
    //    }

    //    public RelayCommand SaveCommand { get; }
    //    public RelayCommand SearchCommand { get; }

    //    public void Save()
    //    {
    //        try
    //        {
    //            var isSaved = _parentService.Add(CurrentParent);
    //            if (isSaved)
    //            {
    //                LoadData();
    //                Message = "Parent saved";
    //                MessageBox.Show("Parent saved");
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

    //    public void Search()
    //    {
    //        try
    //        {
    //            var parent = _parentService.Search(CurrentParent.FirstName);
    //            if (parent != null)
    //            {
    //                CurrentParent = parent;
    //                MessageBox.Show("Parent found");
    //            }
    //            else
    //            {
    //                Message = "[Parent not found";
    //                MessageBox.Show("Parent not found");
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Message = ex.Message;
    //            MessageBox.Show($"Error: {ex.Message}");
    //        }
    //    }

    //} 


    public class ParentViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private readonly ParentService _parentService;

        public ParentViewModel()
        {
            _parentService = new ParentService();
            LoadData();
            CurrentParent = new Parent();
            SaveCommand = new RelayCommand(Save);
            SearchCommand = new RelayCommand(Search);
        }

        private ObservableCollection<Parent> _parentList;
        public ObservableCollection<Parent> ParentList
        {
            get { return _parentList; }
            set { _parentList = value; OnPropertyChanged(); }
        }

        private void LoadData()
        {
            ParentList = new ObservableCollection<Parent>(_parentService.GetAll());
        }

        private Parent _currentParent;
        public Parent CurrentParent
        {
            get { return _currentParent; }
            set { _currentParent = value; OnPropertyChanged(); }
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
                var isSaved = _parentService.Add(CurrentParent);
                if (isSaved)
                {
                    LoadData();
                    Message = "Parent saved";
                    MessageBox.Show("Parent saved");
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
                var parent = _parentService.Search(CurrentParent.FirstName);
                if (parent != null)
                {
                    CurrentParent = parent;
                    MessageBox.Show("Parent found");
                }
                else
                {
                    Message = "Parent not found";
                    MessageBox.Show("Parent not found");
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
