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
            protected string _nev;
            protected int _kor;

            public Szemely(string nev, int kor)
            {
                _nev = nev;
                _kor = kor;
            }
            
            public string Nev
            {
                get { return _nev; }
                set { _nev = value; }
            }
            public int Kor
            {
                get { return _kor; }
                set 
                {
                    if(value >= 0)
                    {
                    _kor = value;
                    }
                    else
                    {
                        Console.WriteLine("Hibás kor!");
                    }
                }
                
            }
            public override string ToString()
            {
                return $"Név: {_nev}, Kor: {_kor}";
            }
        }
        public class BankSzamla
        {
            private uint egyenleg;

            public int Egyenleg
            {
                set
                { 
                    if(value >=0)
                    {
                        egyenleg = (uint)value;
                    }
                    else
                    {
                        Console.WriteLine("Hibás egyenleg!");
                    }
                }
            }
            
            public void Befizetes(uint osszeg)
            {
                egyenleg += osszeg;
            }
            public void Kivesz(uint osszeg)
            {
                egyenleg -= osszeg;
            }

        }
        public class Hallgato : Szemely
        {
            public string NeptunKod { get; set; }
            public Hallgato()
            {

            }
        }
   
        static void Main(string[] args)
        {
            Szemely szemely = new Szemely("Kiss Ilona", 33);
            Console.WriteLine(szemely);

            

        }
    }
}
