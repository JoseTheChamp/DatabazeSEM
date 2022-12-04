using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabazeSEM.Models.Entities
{
    public class Start
    {
        public int Id { get; set; }
        public int Length { get; set; }
        public double? Time { get; set; }

        public Start(int id, int length)
        {
            Id = id;
            Length = length;
        }

        public Start(int id, int length, double? time) : this(id, length)
        {
            Time = time;
        }

        public override string? ToString()
        {
            if (Time.HasValue)
            {
                return Id.ToString() + " - " + Length.ToString() + " : " + Time.ToString();
            }
            return Id.ToString() + " - " + Length.ToString();
        }
    }
}
