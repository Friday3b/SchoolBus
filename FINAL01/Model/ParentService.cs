using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace FINAL01.Model
{
    public class ParentService
    {
        private static List<Parent> ObjParentList;

        static ParentService()
        {
            if (File.Exists("parent.json"))
            {
                string json = File.ReadAllText("parent.json");
                ObjParentList = JsonConvert.DeserializeObject<List<Parent>>(json) ?? new List<Parent>();
            }
            else
            {
                ObjParentList = new List<Parent>
                {
                    new Parent { FirstName = "Haciyev", LastName = "Murad", Phone = "+994555555555", Username = "Haciyevs", Password = "haciyev123" },
                    new Parent { FirstName = "Mahmudov", LastName = "Murad", Phone = "+994555555555", Username = "Haciyevs", Password = "haciyev123" },
                    new Parent { FirstName = "Valishov", LastName = "Murad", Phone = "+994555555555", Username = "Haciyevs", Password = "haciyev123" },
                    new Parent { FirstName = "Hikmetli", LastName = "Murad", Phone = "+994555555555", Username = "Haciyevs", Password = "haciyev123" },
                    new Parent { FirstName = "Savahli", LastName = "Murad", Phone = "+994555555555", Username = "Haciyevs", Password = "haciyev123" },
                };
            }
        }

        public List<Parent> GetAll() => ObjParentList;

        public bool Add(Parent newParent)
        {
            ObjParentList.Add(newParent);
            WriteToJsonFile("parent.json", ObjParentList);
            return true;
        }

        public Parent? Search(string firstName)
        {
            return ObjParentList.FirstOrDefault(e => e.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));
        }

        private void WriteToJsonFile(string fileName, List<Parent> parentList)
        {
            string json = JsonConvert.SerializeObject(parentList, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }
    }
}
