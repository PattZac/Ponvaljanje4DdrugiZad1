using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponvaljanje4DdrugiZad1
{
    internal class Program
    {
        class Biljka
        {

        }
        class Stablo : Biljka
        {
            bool opadajuListovi;

            public bool OpadajuListovi { get => opadajuListovi; set => opadajuListovi = value; }
            public Stablo() { }
            public Stablo(bool b)
            {
                OpadajuListovi = b;
            }
        }
        class Cvijet : Biljka
        {

        }
        class Bijelogoricno : Stablo {
            public Bijelogoricno() { }
            public Bijelogoricno(bool b) { OpadajuListovi = b; }
        }
        class Crnogoricno : Stablo
        {
            public Crnogoricno() { }
            public Crnogoricno(bool b) { OpadajuListovi = b; }
        }
        static void Main(string[] args)
        {
            Bijelogoricno Hrast = new Bijelogoricno(true);
            Crnogoricno Bor = new Crnogoricno(false);
            Console.Write("Hrast ");
            if (Hrast.OpadajuListovi == true) { 
                Console.Write("opadaju listovi."); 
            } 
            else { 
                Console.Write("ne opadaju listovi."); 
            }
            Console.Write(" A bor ");
            if (Bor.OpadajuListovi == true)
            {
                Console.Write("opadaju listovi.");
            }
            else
            {
                Console.Write("ne opadaju listovi.");
            }
            Console.ReadLine();
        }
    }
}
