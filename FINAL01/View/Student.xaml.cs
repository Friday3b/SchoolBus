using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using FINAL01.Command;
using FINAL01.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using FINAL01.ViewModel;

namespace FINAL01.View
{
    /// <summary>
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class Student : Page , INotifyPropertyChanged
    {
        #region INotifyPropertyChanged


        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        public Student()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // DataContext'i StudentViewModel olarak ayarlayın
            this.DataContext = new StudentViewModel();
        }

        private void createstudent(object sender, RoutedEventArgs e)
        {
            CreateStudent createstudent = new CreateStudent();
            this.NavigationService.Navigate(createstudent);
        }

        



        private string firstname;

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; OnPropertyChanged("FirstName"); }
        }


        private string lastname;

        public string LastName
        {
            get { return lastname; }
            set { lastname = value;  OnPropertyChanged("LastName"); }
        }

        private string parent;

        public string Parent
        {
            get { return parent; }
            set { parent = value;  OnPropertyChanged("Parent"); }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; OnPropertyChanged("Gender"); }
        }


        private string homeaddress;

        public string HomeAddress
        {
            get { return homeaddress; }
            set { homeaddress = value; OnPropertyChanged("HomeAddress"); }
        }

        private string otheraddress;

        public string OtherAddress
        {
            get { return otheraddress; }
            set { otheraddress = value; OnPropertyChanged("OtherAddress"); }
        }


    }
}
