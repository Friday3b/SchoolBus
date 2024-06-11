using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FINAL01.Model
{
    public class CarService
    {
        private static List<Car> ObjCarList;

        static CarService()
        {
            if (File.Exists("car.json"))
            {
                string json = File.ReadAllText("car.json");
                ObjCarList = JsonConvert.DeserializeObject<List<Car>>(json) ?? new List<Car>();
            }
            else
            {
                ObjCarList = new List<Car>
                {
                    new Car { Fullname = "MirzeliSabir"  , Name = "Sabir" , SeatCount = 24 , Number="310"},
                    new Car { Fullname = "NamazliKenan"  , Name = "Kenan" , SeatCount = 24 , Number="311"},
                    new Car { Fullname = "MirzeliSabir"  , Name = "Sabir" , SeatCount = 24 , Number="312"},
                };
            }
        }

        public List<Car> GetAll() => ObjCarList;

        public bool Add(Car newCar)
        {
            ObjCarList.Add(newCar);
            WriteToJsonFile("car.json", ObjCarList);
            return true;
        }

        public Car? Search(string firstName)
        {
            return ObjCarList.FirstOrDefault(e => e.Name.Equals(firstName, StringComparison.OrdinalIgnoreCase));
        }

        private void WriteToJsonFile(string fileName, List<Car> carList)
        {
            string json = JsonConvert.SerializeObject(carList, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }
    }
}
