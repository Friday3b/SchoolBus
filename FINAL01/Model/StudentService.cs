using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace FINAL01.Model
{
    //public class StudentService
    //{

    //    private static List<Student> ObjStudentList;

    //    private const string JsonFilePath = "stepstudent001.json";

    //    public StudentService()
    //    {
    //        LoadFromJsonFile();
    //        if (ObjStudentList == null || ObjStudentList.Any())
    //        {

    //            ObjStudentList = new List<Student>()
    //            {
    //                new Student{FirstName ="Haciyev" , LastName= "Taleh" ,  Parent="Khalil" , Gender= "Male" , HomeAddress = "Khirdalan" ,   OtherAddress ="Yasamal"},
    //                new Student{FirstName ="Mahmudov" , LastName= "Ferid" ,     Parent="Nazim" , Gender= "Male" , HomeAddress = "Khirdalan" ,   OtherAddress ="Yasamal"},
    //                new Student{FirstName ="Valishov" , LastName= "Mansur" ,    Parent="Qalib" , Gender= "Male" , HomeAddress = "Khirdalan" ,  OtherAddress ="Yasamal"},
    //                new Student{FirstName ="Hikmetli" , LastName= "Mubarek" ,   Parent="Bilal" , Gender= "Male" , HomeAddress = "Khirdalan" ,     OtherAddress ="Yasamal"},
    //                new Student{FirstName ="Savahli" , LastName= "Kerim" ,  Parent="Sani" , Gender= "Male" , HomeAddress = "Khirdalan" ,     OtherAddress ="Yasamal"},


    //            };
    //            WriteToJsonFile();
    //        }
    //    }

    //    public List<Student> GetAll()
    //    {
    //        return ObjStudentList;
    //    }


    //    public bool Add (Student ObjNewStudent)
    //    {
    //        var newStudent = new Student
    //        {
    //            FirstName = ObjNewStudent.FirstName,
    //            LastName = ObjNewStudent.LastName,
    //            Parent = ObjNewStudent.Parent,
    //            Gender = ObjNewStudent.Gender,
    //            HomeAddress = ObjNewStudent.HomeAddress,
    //            OtherAddress = ObjNewStudent.OtherAddress

    //        };
    //        ObjStudentList.Add(newStudent);
    //        WriteToJsonFile();

    //        return true;
    //    }

    //    public Student? Search(string FirstName)
    //    {
    //        return ObjStudentList.FirstOrDefault(e => e.FirstName.Equals(FirstName, StringComparison.OrdinalIgnoreCase));
    //    }




    //    private void WriteToJsonFile()
    //    {
    //        string json = JsonConvert.SerializeObject(ObjStudentList, Formatting.Indented);
    //        File.WriteAllText(JsonFilePath, json);
    //    }



    //    private void LoadFromJsonFile()
    //    {
    //        if (File.Exists(JsonFilePath))
    //        {
    //            string json = File.ReadAllText(JsonFilePath);
    //            ObjStudentList = JsonConvert.DeserializeObject<List<Student>>(json);
    //        }
    //    }


    //}



    public class StudentService
    {
        private static List<Student> ObjStudentList;

        public StudentService()
        {
            if (File.Exists("students.json"))
            {
                string json = File.ReadAllText("students.json");
                ObjStudentList = JsonConvert.DeserializeObject<List<Student>>(json) ?? new List<Student>();
            }
            else
            {
                ObjStudentList = new List<Student>()
                {
                    new Student{FirstName ="Haciyev", LastName= "Taleh", Parent="Khalil", Gender= "Male", HomeAddress = "Khirdalan", OtherAddress ="Yasamal"},
                    new Student{FirstName ="Mahmudov", LastName= "Ferid", Parent="Nazim", Gender= "Male", HomeAddress = "Khirdalan", OtherAddress ="Yasamal"},
                    new Student{FirstName ="Valishov", LastName= "Mansur", Parent="Qalib", Gender= "Male", HomeAddress = "Khirdalan", OtherAddress ="Yasamal"},
                    new Student{FirstName ="Hikmetli", LastName= "Mubarek", Parent="Bilal", Gender= "Male", HomeAddress = "Khirdalan", OtherAddress ="Yasamal"},
                    new Student{FirstName ="Savahli", LastName= "Kerim", Parent="Sani", Gender= "Male", HomeAddress = "Khirdalan", OtherAddress ="Yasamal"},
                };
            }
        }

        public List<Student> GetAll()
        {
            return ObjStudentList;
        }

        public bool Add(Student newStudent)
        {
            ObjStudentList.Add(newStudent);
            WriteToJsonFile("students.json", ObjStudentList);
            return true;
        }

        public Student? Search(string firstName)
        {
            return ObjStudentList.FirstOrDefault(e => e.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));
        }

        private void WriteToJsonFile(string fileName, List<Student> studentList)
        {
            string json = JsonConvert.SerializeObject(studentList, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }
    }
}
