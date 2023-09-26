using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Síkidomok
{
    internal class Teglalap : Sikidom
    {
        readonly double oldalA;
        readonly double oldalB;

        public Teglalap(double oldalA, double oldalB) : base("Téglalap")
        {
            this.oldalA=oldalA;
            this.oldalB=oldalB;
        }

        public double OldalA => oldalA;

        public double OldalB => oldalB;

        public override double kerület()
        {
            return 2*(oldalA+oldalB);
        }

        public override double terület()
        {
            return oldalA*oldalB;
        }
    }
}
