using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabazeSEM.Models
{
    public class Program
    {
        private string connectionString = "";


        public void EstablishConnection() { 
            
        }

        public List<string> GetAllRaces()
        {
            return TestDataRepository.getAllRaces();
        }

        public string GetRaceInfo(string raceName) {
            return "Lorem ipsum dolor sit amet.";
        }
        public string GetRaceDate(string raceName)
        {
            return "18.5.2023";

        }
        public string GetTypeOfRace(string raceName)
        {
            return "domaci";
        }
        public List<string> GetAllStartsIds(string raceName)
        {
            //pozor na logiku v UI rozd2lit na s casem a bez casu
            List<string> starts = new List<string> { "8","15","12","22" };
            return starts;
        }








    }
}
