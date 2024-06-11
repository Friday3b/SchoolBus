using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FINAL01.Model
{
    class CreateRideService
    {

        private static List<CreateRide> ObjCreateRideList;

        static CreateRideService()
        {
            if (File.Exists("createride.json"))
            {
                string json = File.ReadAllText("createride.json");
                ObjCreateRideList = JsonConvert.DeserializeObject<List<CreateRide>>(json) ?? new List<CreateRide>();
            }
            else
            {
                ObjCreateRideList = new List<CreateRide>
                {
                    new CreateRide { Driver = "Savahli" , Group = "1A" , Locations ="20 Yanvar"}
                    
                };
            }
        }

        public List<CreateRide> GetAll() => ObjCreateRideList;

        public bool Add(CreateRide newCreateRide)
        {
            ObjCreateRideList.Add(newCreateRide);
            WriteToJsonFile("createride.json", ObjCreateRideList);
            return true;
        }

        //burada search e ehtiyac yoxdu cunki verilen melumatlari Ride section da acilacaq , buradan sadece add elemek lazimdi sisteme otursun; 
        //public CreateRide? Search(string firstName)
        //{
        //    return ObjCreateRideList.FirstOrDefault(e => e.Driver.Equals(firstName, StringComparison.OrdinalIgnoreCase));
        //}

        private void WriteToJsonFile(string fileName, List<CreateRide> createrideList)
        {
            string json = JsonConvert.SerializeObject(createrideList, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }
    }
}
