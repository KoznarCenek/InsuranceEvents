using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public void PridatPojistenceDoListu(string jmenoPojisteneho, string prijmeniPojisteneho, int telefoniCisloPojisteneho, int vekPojisteneho)
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

        public IEnumerable<Pojistenec> VyhledejtePojistenehoDotaz(string jmenoPojisteneho, string prijmeniPojisteneho)
        {
            var dotaz = seznamPojistencu.Where(x => (x.Jmeno == jmenoPojisteneho) && (x.Prijmeni == prijmeniPojisteneho));

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
