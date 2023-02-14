﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Insurance
{
    static class Zobrazeni
    {
        public const int PRIDAT = 1;
        public const int VYPSAT = 2;
        public const int VYHLEDAT = 3;
        public const int KONEC = 4;
        public static void ZobrazUvod()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("----------------------------------");
        }
        public static void ZobrazMoznosti()
        {
            Console.WriteLine("Vyberte si akci: ");
            Console.WriteLine("{0} - Přidat nového pojišteného", PRIDAT);
            Console.WriteLine("{0} - Vypsat všechny pojištěné", VYPSAT);
            Console.WriteLine("{0} - Vyhledat pojištěného", VYHLEDAT);
            Console.WriteLine("{0} - konec", KONEC);
        }
        public static int VolbaUzivatele()
        {
            int volba;

            string nacteno = Console.ReadLine();
            bool naparsovat = int.TryParse(nacteno, out volba);
            if (naparsovat)
            {
                Console.WriteLine($"Zadal jsi čislo: '{nacteno}' volba: {volba}.");
            }
            else
            {
                Console.WriteLine($"Zadal jsi: '{nacteno ?? "<null>"}' Zadej prosím číslo 1 - 4");
            }

            return volba;
        }
        public static (string, string, string, int) ZobrazZadavani()
        {
            Console.WriteLine("Zadejte jméno pojistěného: ");
            string jmenoPojisteneho = Console.ReadLine();
            Console.WriteLine("Zadejte přijmení: ");
            string prijmeniPojisteneho = Console.ReadLine();
            Console.WriteLine("Zadejte telefoní číslo: ");
            string telefoniCisloPojisteneho = Console.ReadLine();
            Console.WriteLine("zadejte věk: ");
            int vekPojisteneho = int.Parse(Console.ReadLine());

            return (jmenoPojisteneho, prijmeniPojisteneho, telefoniCisloPojisteneho, vekPojisteneho);
        }
        public static void ZobrazString(string s)
        {
            Console.WriteLine(s);
        }
        public static (string, string) VyhledejtePojistenehoZadavani()
        {
            Console.WriteLine("Zadejte jméno pojistěného: ");
            string jmenoPojisteneho = Console.ReadLine();
            Console.WriteLine("Zadejte přijmení: ");
            string prijmeniPojisteneho = Console.ReadLine();
            
            return (jmenoPojisteneho, prijmeniPojisteneho);
        }
        

    }
}

