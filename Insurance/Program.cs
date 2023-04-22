using System.Security.Policy;

namespace Insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLDataCommunication databaze= new SQLDataCommunication();
            SQLDataCommunication.PripojSeNaDatabazi();

            Pojistenci seznamPojistencu = new Pojistenci();
            Zobrazeni.ZobrazUvod();

            bool konec = false;
            while (konec == false)
            {
                Zobrazeni.ZobrazMoznosti();
                switch (Zobrazeni.VolbaUzivatele("číslo 1- 4"))
                {
                    case Zobrazeni.PRIDAT:
                        (string jmenoPojisteneho, string prijmeniPojisteneho, string telefoniCisloPojisteneho, int vekPojisteneho) = Zobrazeni.ZobrazZadavani();
                        if (Pojistenec.validTelephoneNo(telefoniCisloPojisteneho))
                        {
                            seznamPojistencu.PridatPojistenceDoListu(jmenoPojisteneho, prijmeniPojisteneho, telefoniCisloPojisteneho, vekPojisteneho);
                            Console.Write("Data byla uložena.");
                        }
                        else
                        {
                            Console.WriteLine("Zadal jste nevalidní číslo: {0} Data nebyla uložena", telefoniCisloPojisteneho);
                        }
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