using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    class Pojistenci
    {
        List<Pojistenec> seznamPojistencu;
        public Pojistenci()
        {
            seznamPojistencu = new List<Pojistenec>();
        }

        public Pojistenec jmenoPojisteneho { get; private set; }
        public Pojistenec prijmeniPojisteneho { get; private set; }
        /// <summary>
        /// Přidává pojištěnce do seznamu pojištěnců
        /// </summary>
        public void PridatPojistenceDoListu(string jmenoPojisteneho, string prijmeniPojisteneho, string telefoniCisloPojisteneho, int vekPojisteneho)
        {
            Pojistenec pojistenec1 = new Pojistenec(jmenoPojisteneho, prijmeniPojisteneho, telefoniCisloPojisteneho, vekPojisteneho);
            seznamPojistencu.Add(pojistenec1);
        }
        public string ToString()
        {
            string s = "";
            foreach (Pojistenec p in seznamPojistencu)
            {
                s = s + p.ToString() + "\n";
            }
            return s;
        }
        /// <summary>
        /// Funkce na vyhledávání pojištěnce ze seznamu pojištěnců
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Pojistenec> VyhledejtePojistenehoDotaz(string jmenoPojisteneho, string prijmeniPojisteneho)
        {
            var dotaz = seznamPojistencu.Where(x => (x.Jmeno.Contains(jmenoPojisteneho)) && (x.Prijmeni.Contains(prijmeniPojisteneho)));

            return dotaz;
        }
        public static string IEnumerableToString(IEnumerable<Pojistenec> seznam)
        {
            string s = "";
            foreach (Pojistenec p in seznam)
            {
                s = s + p.ToString() + "\n";
            }
            return s;
        }
    }
}
