using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Cookie
    {
        public string Name { get; set; }
        public bool HasNuts { get; set; }
        public double GramsOfFlour { get; set; }

        public Cookie()
        {
            //*empty constructor
        }

        public Cookie(string name, bool hasNuts, double gramsOfFlour)
        {
            
            //* overloaded constructor with 3 parameters

            Name = name;
            HasNuts = hasNuts;
            GramsOfFlour = gramsOfFlour;
        }
    }

    public enum VehicleType {car, sailboat, powerboat, motorcycle }
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Milage { get; set; }
        public bool IsNew { get; set; }
        public VehicleType Type { get; set; }

        public Vehicle()
        {

        }

    }
    public class Order
    {
        public String CustomerName { get; set; }
        public Cookie OrderedProduct { get; set; }
        public decimal TotalCost { get; set; }
    }
}
