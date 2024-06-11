using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL01.Model
{
    public class Parent : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        private string? firstname;
        public string? FirstName
        {
            get => firstname;
            set { firstname = value; OnPropertyChanged(nameof(FirstName)); }
        }

        private string? lastname;
        public string? LastName
        {
            get => lastname;
            set { lastname = value; OnPropertyChanged(nameof(LastName)); }
        }

        private string? phone;
        public string? Phone
        {
            get => phone;
            set { phone = value; OnPropertyChanged(nameof(Phone)); }
        }

        private string? username;
        public string? Username
        {
            get => username;
            set { username = value; OnPropertyChanged(nameof(Username)); }
        }

        private string? password;
        public string? Password
        {
            get => password;
            set { password = value; OnPropertyChanged(nameof(Password)); }
        }
    }


}

