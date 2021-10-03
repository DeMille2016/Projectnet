using System;

namespace ConsoleApp1
{
    public class Album
    {
        public String Name { get; set; }
        public DateTime Release { get; set; }
        public int Numbers { get; set; }
        public Performer Performer { get; set; }

        public Album(string name, DateTime release, int numbers, Performer performer)
        {
            Name = name;
            Release = release;
            Numbers = numbers;
            Performer = performer;
        }

        public override string ToString()
        {
            return $"Album: '{Name}'-{Numbers} from {Performer}";
        }
    }
}