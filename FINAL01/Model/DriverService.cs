using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FINAL01.Model
{
    public class DriverService
    {
        private static List<Driver> ObjDriverList;

        static DriverService()
        {
            if (File.Exists("driver.json"))
            {
                string json = File.ReadAllText("parent.json");
                ObjDriverList = JsonConvert.DeserializeObject<List<Driver>>(json) ?? new List<Driver>();
            }
            else
            {
                ObjDriverList = new List<Driver>
                {
                    new Driver { FirstName = "Haciyev", LastName = "Murad", Phone = "+994555555555", Username = "Haciyevs", Car = "Ford" , License = "have license till 2030" },
                    new Driver { FirstName = "Veliyev", LastName = "Shain", Phone = "+994555555555", Username = "Veliyevs", Car = "Ford" , License = "have license till 2030" },
                    new Driver { FirstName = "Mahmudlu", LastName = "Kamandar", Phone = "+994555555555", Username = "Mahmudlus", Car = "Ford" , License = "have license till 2030" },

                };
            }
        }

        public List<Driver> GetAll() => ObjDriverList;

        public bool Add(Driver newDriver)
        {
            ObjDriverList.Add(newDriver);
            WriteToJsonFile("driver.json", ObjDriverList);
            return true;
        }

        public Driver? Search(string firstName)
        {
            return ObjDriverList.FirstOrDefault(e => e.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));
        }

        private void WriteToJsonFile(string fileName, List<Driver> driverList)
        {
            string json = JsonConvert.SerializeObject(driverList, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }
    }
}
