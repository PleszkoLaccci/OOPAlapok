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

            public Szemely(string nev)
            {
                _nev = nev;
                
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
   
        static void Main(string[] args)
        {
            Szemely szemely = new Szemely("Kiss Ilona");
            szemely.Kor = 25;
            Console.WriteLine(szemely);

            

        }
    }
}
