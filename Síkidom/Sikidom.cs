using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Síkidomok
{
    internal class Sikidom
    {
        public string Síkidom;
        public override string ToString()
        {
            return this.Síkidom;
        }
        public Sikidom(string síkidom)
        {
            this.Síkidom = síkidom;
        }
    }
}
