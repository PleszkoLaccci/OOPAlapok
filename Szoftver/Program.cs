using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static Szoftver.Program;

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
            private string _neptunkod;

            public string Neptunkod
            {
                set
                {
                    if (value.Length <= 6)
                    {
                        _neptunkod = value;
                    }
                    else
                    {
                        Console.WriteLine("Hibás neptuknód");
                    }
                }
                get { return _neptunkod; }
            }
            public Hallgato(string nev, int kor) : base(nev,kor)
            {
               
                _nev = nev;
                _kor = kor;
                


            }
        }
   
        static void Main(string[] args)
        {
            Szemely szemely = new Szemely("Kiss Ilona", 33);
            Console.WriteLine(szemely);

            List <Hallgato> hallgatolista = new List<Hallgato>();

            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Adja meg {i+1} hallgató nevét:");
                string nev = Console.ReadLine();
                Console.Write($"Adja meg {i + 1} hallgató korát:");
                int kor = int.Parse(Console.ReadLine());
                Hallgato hallgato = new Hallgato(nev, kor);
                Console.Write($"Adja meg {i + 1} tanuló neptukódját:");
                string neptunkod = Console.ReadLine();
                hallgato.Neptunkod = neptunkod;

                hallgatolista.Add(hallgato);

                
            }

            foreach(Hallgato hallgato in hallgatolista)
            {
                Console.WriteLine("Neve:" +hallgato.Nev);
                Console.WriteLine($"{hallgato.Nev} kora: " +hallgato.Kor);
                Console.WriteLine($"{hallgato.Nev} neptunkódja: "+hallgato.Neptunkod);

            }


        }
    }
}
