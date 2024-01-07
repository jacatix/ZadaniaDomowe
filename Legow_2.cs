using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legow_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double wynik;
            wynik = (Math.Sqrt(Math.PI) + Math.Exp(1)) / (Math.Log(Math.PI, 10) + Math.Log(Math.Exp(1)));
            Console.WriteLine("Polecenie 11\nWynik dzialania: {0:#.####}", wynik);
            Console.ReadKey(true);
        }
    }
}
