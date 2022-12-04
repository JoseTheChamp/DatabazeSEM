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

        public List<string> getAllRaces()
        {
            return TestDataRepository.getAllRaces();
        }





    }
}
