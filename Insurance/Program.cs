using System.Security.Policy;

namespace Insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Zobrazeni.ZobrazZobrazeni();
            switch (Zobrazeni.VolbaUzivatele())
            {
                case Zobrazeni.PRIDAT:

                    break;
                case Zobrazeni.VYPSAT:
                    break;
                default: Console.WriteLine("Neplatná volba");

                    break;
            }

            Console.WriteLine("Zadejte jméno pojistěného: ");
            string jmenoPojisteneho = Console.ReadLine(); 
            Console.WriteLine("Zadejte přijmení: ");
            string prijmeniPojisteneho = Console.ReadLine();
            Console.WriteLine("Zadejte telefoní číslo: ");
            int telefoniCisloPojisteneho = int.Parse(Console.ReadLine());
            Console.WriteLine("zadejte věk: ");
            int vekPojisteneho = int.Parse(Console.ReadLine());
            List<Pojistenec> seznamPojistencu = new List<Pojistenec>();
            Pojistenec pojistenec1 = new Pojistenec(jmenoPojisteneho, prijmeniPojisteneho, telefoniCisloPojisteneho, vekPojisteneho);
            seznamPojistencu.Add(pojistenec1);
            Console.WriteLine(pojistenec1.ToString());
            Console.WriteLine("Data byla uložena. Pokračujte libolnou klávesou...");
        }
    }
}