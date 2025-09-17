using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szoftver
{
    internal class Program
    {
        public class Szemely
        {
            public string nev = "Nagy Ilona";
            public int kor = 21;

        }
        static void Main(string[] args)
        {
            Szemely szemely = new Szemely();
            Console.WriteLine("Név: " + szemely.nev);
            Console.WriteLine("Kor: " + szemely.kor);
            Console.ReadKey();
        }
    }
}
