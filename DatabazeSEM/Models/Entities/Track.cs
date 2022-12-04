using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabazeSEM.Models.Entities
{
    public class Track
    {
        public int ID { get; set; }
        public int Length { get; set; }
        public int Rounds { get; set; } = 1;

        public Track(int iD, int length)
        {
            ID = iD;
            Length = length;
        }

        public Track(int iD, int length, int rounds) : this(iD, length)
        {
            Rounds = rounds;
        }

        public override string? ToString()
        {
            return ID + " - " + Length + "m - " + Rounds + "*";
        }
    }
}
