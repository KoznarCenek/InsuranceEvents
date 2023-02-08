using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    static class Zobrazeni
    {
        public const int PRIDAT = 1;
        public const int VYPSAT = 2;
        public const int VYHLEDAT = 3;
        public const int KONEC = 4;
        public static void ZobrazZobrazeni() 
        {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Evidence pojištěných");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Vyberte si akci: ");
        Console.WriteLine("{0} - Přidat nového pojišteného", PRIDAT);
        Console.WriteLine("2 - Vypsat všechny pojištěné");
        Console.WriteLine("3 - Vyhledat pojištěného");
        Console.WriteLine("4 - konec");
        }
        public static int VolbaUzivatele()
        {
            int volba;

            bool success = int.TryParse(Console.ReadLine(), out volba);
            if (success)
            {
                Console.WriteLine($"Converted '{Console.ReadLine()}' to {volba}.");
            }
            else
            {
                Console.WriteLine($"Attempted conversion of '{Console.ReadLine() ?? "<null>"}' failed.");
            }
            
            return volba;
        }
    }
}
