using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Síkidomok
{
    abstract class Sikidom
    {
        public string tipus;
        public abstract double kerület();
        public abstract double terület();
        public override string ToString()
        {
            return this.tipus;
        }
        public Sikidom(string tipus)
        {
            this.tipus = tipus;
        }
    }
}
