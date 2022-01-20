using System;
using Pierwiastki;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pierwiastki = new PierwiastkiFunkcji();
            Console.WriteLine(pierwiastki.Pierwiastki(1,4,3));
            Console.ReadKey();
        }
    }
}
