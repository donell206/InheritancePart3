using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePart3.Models
{
    public class Auto
    {
        
       // public const int NumberOfDoors = 4;
        //public readonly int NumberOfDoors;
        public string Type { get; set; }
        public static readonly int NumberOfDoors;

        public Auto(int doors)
        {
            //NumberOfDoors = doors;
        }

        static Auto()
        {
            NumberOfDoors++;
        }


    }
}
