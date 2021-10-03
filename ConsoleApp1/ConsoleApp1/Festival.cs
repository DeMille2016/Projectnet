using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Festival
    {
        public String Name { get; set; }
        public double Price { get; set; }
        public String Location { get; set; }
        public List<Performer> Performers { get; set; }

        public Festival(string name, double price, string location)
        {
            Name = name;
            Price = price;
            Location = location;
        }
        public override string ToString()
        {
            return $"Festival: '{Name}' in {Location} (${Price}) ";;
        }
    }
}