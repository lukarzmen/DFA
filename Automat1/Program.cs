using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Automat automat = new Automat1.Automat();
            Console.WriteLine("Herbata w cenie 5zl");
            Console.WriteLine();
            while (true)
            {
                int moneta = 0;
                
                Console.WriteLine("Aktualny stan:" + automat.Stan);

                Console.WriteLine("Wrzuc monete");
                string input = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Wczytano: " + input);
                Int32.TryParse(input, out moneta);
                automat.AutomatDoNapojow(moneta);

                Console.WriteLine("Sciezka stanow: ");
                foreach (var stany in automat.SciezkaStanow)
                    Console.Write("->" + stany );
                Console.WriteLine();
                }
            }
        }
    }

