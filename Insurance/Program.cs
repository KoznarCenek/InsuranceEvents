﻿using System.Security.Policy;

namespace Insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Pojistenci seznamPojistencu = new Pojistenci();
            Zobrazeni.ZobrazUvod();

            bool konec = false;
            while (konec == false)
            {
                Zobrazeni.ZobrazMoznosti();
                switch (Zobrazeni.VolbaUzivatele())
                {
                    case Zobrazeni.PRIDAT:
                        (string jmenoPojisteneho, string prijmeniPojisteneho, string telefoniCisloPojisteneho, int vekPojisteneho) = Zobrazeni.ZobrazZadavani();
                        seznamPojistencu.PridatPojistenceDoListu(jmenoPojisteneho,prijmeniPojisteneho,telefoniCisloPojisteneho,vekPojisteneho);
                        Console.Write("Data byla uložena.");
                        break;
                    case Zobrazeni.VYPSAT:
                        Zobrazeni.ZobrazString(seznamPojistencu.ToString());
                        break;
                    case Zobrazeni.VYHLEDAT:
                        Console.WriteLine("Vyhledat");
                        (string jmenoPojistenehoVyhledej, string prijmeniPojistenehoVyhledej) = Zobrazeni.VyhledejtePojistenehoZadavani();
                        IEnumerable<Pojistenec> seznam = seznamPojistencu.VyhledejtePojistenehoDotaz(jmenoPojistenehoVyhledej, prijmeniPojistenehoVyhledej);
                        string s = Pojistenci.IEnumerableToString(seznam);
                        if (s == null || s == "")
                        {
                            s = "Pojištěnec s těmito údaji nenalezen.";
                        }
                        Zobrazeni.ZobrazString(s);
                        break;
                    case Zobrazeni.KONEC:
                        Console.WriteLine("Děkuji za využití aplikace");
                        konec = true;
                        break;
                    default:
                        Console.WriteLine("Neplatná volba");
                        break;
                }
                Console.WriteLine("Pokračujte libolnou klávesou...");
                
                Console.ReadKey();

            }

            

        }
    }
}