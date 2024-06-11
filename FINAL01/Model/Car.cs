using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL01.Model
{
    public class Car :INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));


            }
        }

        private string? fullname;

        public string? Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }


        private string? name;

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        private string? number;

        public string? Number
        {
            get { return number; }
            set { number = value; }
        }

        private int seatcount;

        public int SeatCount
        {
            get { return seatcount; }
            set { seatcount = value; }
        }


    }
}
