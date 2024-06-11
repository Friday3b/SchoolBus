using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FINAL01.Model
{
    public class ClassService
    {
        private static List<Class> ObjClassList;

        static ClassService()
        {
            if (File.Exists("class.json"))
            {
                string json = File.ReadAllText("class.json");
                ObjClassList = JsonConvert.DeserializeObject<List<Class>>(json) ?? new List<Class>();
            }
            else
            {
                ObjClassList = new List<Class>
                {
                    new Class { Classname = "1A" , Actions = "12" , AssemblyPoint ="20 Yanvar metrosu"} ,
                    new Class { Classname = "1B" , Actions = "12"  , AssemblyPoint = "Xalqlar dostluqu metrosu"} ,
                    new Class { Classname = "1C" , Actions = "12"  , AssemblyPoint =" Neriman Nerimanov metrosu"} ,
                    new Class { Classname = "1D" , Actions = "12"  , AssemblyPoint =" 28 May metrosu"} ,
                };
            }
        }

        public List<Class> GetAll() => ObjClassList;

        public bool Add(Class newClass)
        {
            ObjClassList.Add(newClass);
            WriteToJsonFile("class.json", ObjClassList);
            return true;
        }

        public Class? Search(string firstName)
        {
            return ObjClassList.FirstOrDefault(e => e.Classname.Equals(firstName, StringComparison.OrdinalIgnoreCase));
        }

        private void WriteToJsonFile(string fileName, List<Class> classList)
        {
            string json = JsonConvert.SerializeObject(classList, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }
    }
}
