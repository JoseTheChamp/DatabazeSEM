using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabazeSEM.Models
{
    public static class TestDataRepository
    {
        public static List<string> getAllRaces() {
            List<string> races = new List<string> {"Pohar1","Ppohar2","O pohar lidi Jelenove"};
            return races;
        }
    }
}
