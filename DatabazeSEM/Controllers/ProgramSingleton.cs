using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabazeSEM.Models
{
    public sealed class ProgramSingleton
    {
        private static Program instance;
        private static readonly object padlock = new object();

        ProgramSingleton()
        {
        }

        public static Program Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Program();
                    }
                    return instance;
                }
            }
        }
    }
}
