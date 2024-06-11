using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL01.Model
{
    public class Class : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) 
            { PropertyChanged(this, new PropertyChangedEventArgs(propertyName));}
        }

        private string classname;

        public string Classname
        {
            get { return classname; }
            set { classname = value; }
        }

        private string actions;

        public string Actions
        {
            get { return actions; }
            set { actions = value; }
        }
        //toplanma noqtesi yaratdim ki her qrupu mueyyen yerden yeni umumi oalraq 1 yerden yigsin ve mektebe aparsin sonrada hemin yere getirsin ushaqlari --> bu avtobusun ish prinsipi budur . 

        private string assemblypoint;

        public string AssemblyPoint
        {
            get { return assemblypoint; }
            set { assemblypoint = value; }
        }














    }

}
