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
using FINAL01.Model;

namespace FINAL01.ViewModel
{
    public class ClassViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


        private readonly ClassService _classService;

        public ClassViewModel()
        {
            _classService = new ClassService();
            LoadData();
            CurrentClass = new Class();
            SaveCommand = new RelayCommand(Save);
            SearchCommand = new RelayCommand(Search);
        }

        private ObservableCollection<Class> _classList;
        public ObservableCollection<Class> ClassList
        {
            get { return _classList; }
            set { _classList = value; OnPropertyChanged(); }
        }

        private void LoadData()
        {
            ClassList = new ObservableCollection<Class>(_classService.GetAll());
        }

        private Class _currentClass;
        public Class CurrentClass
        {
            get { return _currentClass; }
            set { _currentClass = value; OnPropertyChanged(); }
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
                var isSaved = _classService.Add(CurrentClass);
                if (isSaved)
                {
                    LoadData();
                    Message = "Class saved";
                    MessageBox.Show("Class saved");
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
                if (string.IsNullOrWhiteSpace(CurrentClass.Classname))
                {
                    LoadData();
                    MessageBox.Show("All Class is here ");
                }
                //burada butun driverlar search commandasinda emnpty olaraq search etsek cixacaq deye etdim ...

                else
                {
                    var driver = _classService.Search(CurrentClass.Classname);
                    if (driver != null)
                    {
                        CurrentClass = driver;
                        ClassList.Clear();
                        ClassList.Add(driver);
                        MessageBox.Show("Class found");
                    }
                    else
                    {
                        Message = "Class not found";
                        MessageBox.Show("Class not found");
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
