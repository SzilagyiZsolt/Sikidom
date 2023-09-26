using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Síkidomok
{
    internal class Negyzet : Sikidom
    {
        public double oldal;
        public Negyzet(double oldal) : base("Négyzet")
        {
            this.oldal = oldal;
        }

        public double Oldal { get => oldal;}

        public override double kerület()
        {
            return oldal*4;
        }

        public override double terület()
        {
            return oldal*oldal;
        }
    }
}
