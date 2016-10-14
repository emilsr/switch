using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_satsen
{
    class Program
    {
        static void Main(string[] args)
        {


            //övning1
            Console.WriteLine("skriv ett heltal");
            int tal = int.Parse(Console.ReadLine());

            switch (tal)
            {

                case 1: Console.WriteLine("ett"); break;
                case 2: Console.WriteLine("två"); break;
                case 3: Console.WriteLine("tre"); break;
                case 4: Console.WriteLine("fyra"); break;
                default:
                    Console.WriteLine("ogiltig"); break;




                    //övning2

                    Console.WriteLine("skriv N, S, E eller W");
                    string bokstav = Console.ReadLine();

                    switch (bokstav)
                    {

                        case "N": Console.WriteLine("ett"); break;
                        case "S": Console.WriteLine("två"); break;
                        case "E": Console.WriteLine("tre"); break;
                        case "W": Console.WriteLine("fyra"); break;
                        default:
                            Console.WriteLine("I don't understand!"); break;




                            /*
                            //övning3

                            Console.Write("skriv in två tal");
                            int tal2 = int.Parse(Console.ReadLine());
                            int tal3 = int.Parse(Console.ReadLine());



                            switch (type)
                            {


                                case 1: Console.WriteLine(tal2 * tal3); break;
                                case 2: Console.WriteLine(tal2 / tal3); break;
                                case 3: Console.WriteLine(tal2 + tal3); break;
                                case 4: Console.WriteLine(tal2 - tal3); break;
                                default: Console.WriteLine("försök igen"); break;

                            }
                            */




                            Console.ReadKey();









                    }
            }
        }
    }
}
