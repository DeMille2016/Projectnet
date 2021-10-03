using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Performer
    {
        public String Name { get; set; }
        public Genre Genre { get; set; }
        public int Members { get; set; }
        public List<Festival> Festivals { get; set; }
        public List<Album> Albums { get; set; }

        public Performer(string name, Genre genre, int members)
        {
            Name = name;
            Genre = genre;
            Members = members;
        }

        public override string ToString()
        {
            return $"Performer: '{Name}' with {Members} members, Genre: {Genre}";
        }
    }
    
    
}