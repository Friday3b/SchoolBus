using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL01.Model
{
    public class Student:INotifyPropertyChanged
    {

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));


            }
        }
        #endregion


        private string? firstname;

        public string? FirstName
        {
            get { return firstname; }
            set { firstname = value; OnPropertyChanged("FirstName"); }
        }


        private string? lastname;

        public string? LastName
        {
            get { return lastname; }
            set { lastname = value; OnPropertyChanged("LastName"); }
        }


        private string? parent;

        public string? Parent
        {
            get { return parent; }
            set { parent = value; OnPropertyChanged("Parent"); }
        }


        private string? gender;

        public  string? Gender
        {
            get { return gender; }
            set { gender = value; OnPropertyChanged("Gender"); }
        }

        private string? homeaddress;

        public string? HomeAddress
        {
            get { return homeaddress; }
            set { homeaddress = value; OnPropertyChanged("Home Address"); }
        }

        private string? otheraddress ;

        public string? OtherAddress
        {
            get { return otheraddress; }
            set { otheraddress = value; OnPropertyChanged("OtherAddress"); }
        }

    }
}
