using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szoftver
{
    internal class Program
    {
        public class Szemely
        {
            private string _nev;
            private int _kor;

            public Szemely(string nev, int kor)
            {
                _nev = nev;
                _kor = kor;
            }
            public string kiir()
            {
                return _nev + " " + _kor;
            }
        }
        public class BankSzamla
        {
            private string szamlaszam;
        }
   
        static void Main(string[] args)
        {
            Szemely szemely = new Szemely("Kiss Ilona", 44);

            Console.WriteLine(szemely.kiir());


        }
    }
}
