using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cislo policie: "+TelefonniSeznam.policie);
            Console.WriteLine("Cislo záchranky: " + TelefonniSeznam.zachranka);
            Console.WriteLine("Cislo hasičů: " + TelefonniSeznam.hasici);
            TelefonniSeznam telefon = new TelefonniSeznam(732902293);
            Console.WriteLine("Moje číslo: "+telefon.mojeCislo); 


        }
    }
}
