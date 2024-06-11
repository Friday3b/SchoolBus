using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL01.Model
{
    public class Driver : INotifyPropertyChanged
    {

        #region OnPropertyChanged

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
            set { firstname = value; }
        }


        private string? lastname;

        public string? LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }


        private string? username;

        public string? Username
        {
            get { return username; }
            set { username = value; }
        }

        private string? phone;

        public string? Phone
        {
            get { return phone; }
            set { phone = value; }
        }


        private string car;

        public string Car
        {
            get { return car; }
            set { car = value; }
        }

        private string license;

        public string License
        {
            get { return license; }
            set { license = value; }
        }

        private string action;

        public string Action
        {
            get { return action; }
            set { action = value; }
        }



    }
}
