using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Síkidomok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sikidom> Síkidom = new List<Sikidom>();
            Síkidom.Add(new Kor("Kör"));
            Síkidom.Add(new Teglalap("Téglalap"));
            Síkidom.Add(new Negyzet("Négyzet"));
            foreach (var item in Síkidom)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
