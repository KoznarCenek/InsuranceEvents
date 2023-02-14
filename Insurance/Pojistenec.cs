using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    class Pojistenec
    {
        private string jmeno;
        private string prijmeni;
        private string telefoniCislo;
        private int vek;

        public Pojistenec(string jmeno, string prijmeni, string telefoniCislo, int vek)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.telefoniCislo = telefoniCislo;
            this.vek = vek;
        }

        public string Jmeno { get => jmeno; set => jmeno = value; }
        public string Prijmeni { get => prijmeni; set => prijmeni = value; }
        public string TelefoniCislo { get => telefoniCislo; set => telefoniCislo = value; }
        public int Vek { get => vek; set => vek = value; }

        public override string ToString() 
        {
            return  $"{jmeno} {prijmeni} {telefoniCislo} {vek}";
        }
        

    }
}
