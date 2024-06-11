using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FINAL01.Command;
using FINAL01.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;


namespace FINAL01.ViewModel
{
    //public class StudentViewModel : INotifyPropertyChanged
    //{

    //    #region INotifyPropertyChanged

    //    public event PropertyChangedEventHandler? PropertyChanged;

    //    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }

    //    #endregion

    //    private StudentService _studentService;



    //    StudentService ObjStudentService;

    //    public StudentViewModel()
    //    {
    //        ObjStudentService = new StudentService();
    //        LoadData();
    //        currentStudent = new Student();
    //        saveCommand = new RelayCommand(Save);
    //        searchCommand = new RelayCommand(Search);
    //    }

    //    private ObservableCollection<Student> student_list;

    //    public ObservableCollection<Student> Student_List
    //    {
    //        get { return student_list; }
    //        set { student_list = value; OnPropertyChanged("StudentList"); }
    //    }

    //    private void LoadData()
    //    {
    //        Student_List = new ObservableCollection<Student>(ObjStudentService.GetAll());
    //    }

    //    private Student currentStudent;

    //    public Student CurrentStudent
    //    {
    //        get { return currentStudent; }
    //        set { currentStudent = value; OnPropertyChanged("Current Student"); }
    //    }

    //    private string message;

    //    public string Message
    //    {
    //        get { return message; }
    //        set { message = value; OnPropertyChanged("Message"); }
    //    }

    //    private RelayCommand saveCommand;
    //    public RelayCommand SaveCommand
    //    {
    //        get { return saveCommand; }
    //    }

    //    public void Save()
    //    {
    //        try
    //        {
    //            var IsSaved = ObjStudentService.Add(CurrentStudent);
    //            LoadData();
    //            if (IsSaved)
    //            {
    //                Message = "Student saved";
    //                MessageBox.Show("Student saved");
    //                Student_List.Add(CurrentStudent);
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

    //    private RelayCommand searchCommand;
    //    public RelayCommand SearchCommand
    //    {
    //        get { return searchCommand; }
    //    }

    //    public void Search()
    //    {
    //        try
    //        {
    //            var ObjStudent = ObjStudentService.Search(CurrentStudent.FirstName);

    //            if (ObjStudent != null)
    //            {

    //                CurrentStudent.FirstName = ObjStudent.FirstName;
    //                CurrentStudent.LastName = ObjStudent.LastName;
    //                CurrentStudent.Parent = ObjStudent.Parent; 

    //                Student_List.Clear();
    //                Student_List.Add(CurrentStudent);


    //                //CurrentStudent.FirstName = ObjStudent.FirstName;
    //                //CurrentStudent.LastName = ObjStudent.LastName;
    //                //CurrentStudent.Parent = ObjStudent.Parent;
    //                //CurrentStudent.Gender = ObjStudent.Gender;
    //                //CurrentStudent.HomeAddress = ObjStudent.HomeAddress;
    //                //CurrentStudent.OtherAddress = ObjStudent.OtherAddress;
    //            }
    //            else
    //            {
    //                Message = "Student not found";
    //                MessageBox.Show("Student not found");
    //                Student_List.Clear();
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Message = ex.Message;
    //            MessageBox.Show($"Error: {ex.Message}");
    //        }
    //    }
    //}



    //public class StudentViewModel : INotifyPropertyChanged
    //{
    //    #region INotifyPropertyChanged

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }

    //    #endregion

    //    private StudentService _studentService;
    //    private ObservableCollection<Student> student_list;
    //    private Student currentStudent;
    //    private string message;
    //    private RelayCommand saveCommand;
    //    private RelayCommand searchCommand;

    //    public StudentViewModel()
    //    {
    //        _studentService = new StudentService();
    //        LoadData();
    //        CurrentStudent = new Student();
    //        saveCommand = new RelayCommand(Save);
    //        searchCommand = new RelayCommand(Search);
    //    }

    //    public ObservableCollection<Student> Student_List
    //    {
    //        get { return student_list; }
    //        set { student_list = value; OnPropertyChanged(); }
    //    }

    //    public Student CurrentStudent
    //    {
    //        get { return currentStudent; }
    //        set { currentStudent = value; OnPropertyChanged(); }
    //    }

    //    public string Message
    //    {
    //        get { return message; }
    //        set { message = value; OnPropertyChanged(); }
    //    }

    //    public RelayCommand SaveCommand
    //    {
    //        get { return saveCommand; }
    //    }

    //    public RelayCommand SearchCommand
    //    {
    //        get { return searchCommand; }
    //    }

    //    private void LoadData()
    //    {
    //        Student_List = new ObservableCollection<Student>(_studentService.GetAll());
    //    }

    //    public void Save()
    //    {
    //        try
    //        {
    //            var isSaved = _studentService.Add(CurrentStudent);
    //            if (isSaved)
    //            {
    //                Message = "Student saved";
    //                MessageBox.Show("Student saved");
    //                LoadData(); // Refresh the student list
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
    //            var student = _studentService.Search(CurrentStudent.FirstName);
    //            if (student != null)
    //            {
    //                CurrentStudent = student;
    //                Student_List.Clear();
    //                Student_List.Add(CurrentStudent);
    //            }
    //            else
    //            {
    //                Message = "Student not found";
    //                MessageBox.Show("Student not found");
    //                Student_List.Clear();
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Message = ex.Message;
    //            MessageBox.Show($"Error: {ex.Message}");
    //        }
    //    }
    //}



    public class StudentViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        private StudentService _studentService;

        public StudentViewModel()
        {
            _studentService = new StudentService();
            LoadData();
            CurrentStudent = new Student();
            SaveCommand = new RelayCommand(Save);
            SearchCommand = new RelayCommand(Search);
        }

        private ObservableCollection<Student> _studentList;
        public ObservableCollection<Student> StudentList
        {
            get { return _studentList; }
            set { _studentList = value; OnPropertyChanged(); }
        }

        private void LoadData()
        {
            StudentList = new ObservableCollection<Student>(_studentService.GetAll());
        }

        private Student _currentStudent;
        public Student CurrentStudent
        {
            get { return _currentStudent; }
            set { _currentStudent = value; OnPropertyChanged(); }
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
                var isSaved = _studentService.Add(CurrentStudent);
                if (isSaved)
                {
                    LoadData();
                    Message = "Student saved";
                    MessageBox.Show("Student saved");
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
                if (string.IsNullOrWhiteSpace(CurrentStudent.FirstName))
                {
                    LoadData();
                    MessageBox.Show("All student is here ");
                }
                //burada butun driverlar search commandasinda emnpty olaraq search etsek cixacaq deye etdim ...

                else
                {
                    var student = _studentService.Search(CurrentStudent.FirstName);
                    if (student != null)
                    {
                        CurrentStudent = student;
                        StudentList.Clear();
                        StudentList.Add(student);
                        MessageBox.Show("Student found");
                    }
                    else
                    {
                        Message = "Student not found";
                        MessageBox.Show("Student not found");
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
