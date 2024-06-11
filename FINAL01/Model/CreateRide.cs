using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL01.Model
{
    class CreateRide :INotifyPropertyChanged
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




        private string? driver;
		public string? Driver
		{
			get { return driver; }
			set { driver = value; }
		}




		private string? group;
		public string? Group
		{
			get { return group; }
			set { group = value; }
		}




		private string? locations;


        public string? Locations
		{
			get { return locations; }
			set { locations = value; }
		}


	}
}
