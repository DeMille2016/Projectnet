using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Seed(List<Performer> performers, List<Festival> festivals)
        {
            Performer sc = new Performer("Scrillex", Genre.DUBSTEP, 1);
            Performer m = new Performer("Metallica", Genre.ROCK, 4);
            Performer cp = new Performer("Coldplay", Genre.POP, 4);
            Performer sd = new Performer("Snoop Dogg", Genre.HIP_HOP, 1);
            performers.Add(sc);
            performers.Add(m);
            performers.Add(cp);
            performers.Add(sd);
            Festival rw = new Festival("Rock Werchter", 242.40, "Werchter");
            Festival gf = new Festival("Glastonbury Festival", 211.10, "Glastonbury");
            Festival ws = new Festival("Woodstock", 42.0, "Bethel");
            Festival c = new Festival("Coachella Valley Music and Arts Festival", 355.99, "Indio");
            festivals.Add(rw);
            festivals.Add(gf);
            festivals.Add(ws);
            festivals.Add(c);
            sc.Festivals = new List<Festival>() {rw, gf};
            m.Festivals = new List<Festival>() {rw, ws};
            cp.Festivals = new List<Festival>() {c, gf};
            sd.Festivals = new List<Festival>() {rw, gf, c};
            rw.Performers = new List<Performer>() {sc, m, cp};
            gf.Performers = new List<Performer>() {sc, m, sd};
            ws.Performers = new List<Performer>() {m, cp, cp};
            c.Performers = new List<Performer>() {cp, m, sd};


            //  performers[1].Festivals.Add(festivals[2]);
            // performers[1].Festivals.Add(festivals[1]);
            //  performers[1].Festivals.Add(festivals[3]);
            //  performers[2].Festivals.Add(festivals[1]);
            // performers[2].Festivals.Add(festivals[1]);
            //  performers[2].Festivals.Add(festivals[2]);
            // performers[3].Festivals.Add(festivals[2]);
            //   performers[3].Festivals.Add(festivals[3]);
        }

        void Run()
        {
            List<Performer> performers = new List<Performer>();
            List<Festival> festivals = new List<Festival>();
            Seed(performers, festivals);
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("==============================================================");
            Console.WriteLine("0) Quit");
            Console.WriteLine("1) Show all performers");
            Console.WriteLine("2) Show performers of Genre");
            Console.WriteLine("3) Show all Festivals");
            Console.WriteLine("4) Show performers with name and or number of members");
            Console.Write("Choice (0-4): ");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    break;
                case 1:
                    performers.ForEach(Console.WriteLine);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Genre (1=Pop, 2=Rock, 3=Hip-Hop, 4=Techno, 5=DnB, 6=Jazz, 7=Dubstep):");
                    int gchoice = Int32.Parse(Console.ReadLine());
                    gchoice--;
                    foreach (var performer in performers)
                    {
                        if ((byte) performer.Genre == gchoice)
                        {
                            Console.WriteLine(performer);
                        }
                    }

                    Console.ReadLine();


                    break;
                case 3:
                    festivals.ForEach(Console.WriteLine);
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Give name or not");
                    string naam = Console.ReadLine().ToString();
                    Console.WriteLine("Give number of members or not");
                    string groep = Console.ReadLine();
                    List<Performer> namelist = performers.FindAll(i => i.Name.Contains(naam));
                    if (groep.Length!=0)
                    {
                        int gr = Int32.Parse(groep);


                        List<Performer> printlist = namelist.FindAll(i => i.Members == gr);
                        printlist.ForEach(Console.WriteLine);
                    }
                    else
                    {
                        namelist.ForEach(Console.WriteLine);
                    }

                    Console.ReadLine();
                    break;
            }
        }
    }
}