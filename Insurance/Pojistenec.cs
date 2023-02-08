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
        private int telefoniCislo;
        private int vek;

        public Pojistenec(string jmeno, string prijmeni, int telefoniCislo , int vek)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.telefoniCislo = telefoniCislo;
            this.vek = vek;
        }
        public override string ToString() 
        {
            return  $"{jmeno} {prijmeni} {telefoniCislo} {vek}";
        }
        //public vypisVsechnyPojistence
        //{
           
        //}
    }
}
