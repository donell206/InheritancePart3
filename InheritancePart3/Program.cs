using InheritancePart3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePart3
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto(5);  //initialisatie van read-only
            auto.Type = "Sedan";

            Console.WriteLine(auto.Type);
            Console.WriteLine(auto.NumberOfDoors+ " "+ "Doors");

        }
    }
}
