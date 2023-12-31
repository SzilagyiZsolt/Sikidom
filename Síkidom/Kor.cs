﻿using Síkidom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Síkidomok
{
    internal class Kor : Sikidom, IAtmeretez, IRajzolas
    {
        public double sugár;
        public double átmérő;
        public Kor(double sugár) : base("Kör")
        {
            this.sugár=sugár;
            this.átmérő=2*sugár;
        }
        
        public double Sugar { get => sugár; }
        public double Átmérő { get => átmérő; }

        public override double kerület()
        {
            return 2*sugár*Math.PI;
        }
        public override double terület()
        {
            return sugár*sugár*Math.PI;
        }
        public void Kisebb()
        {
            Console.WriteLine("kisebb");
        }

        public void Nagyobb()
        {
            Console.WriteLine("nagyobb");
        }
        public void Vonalvastag()
        {
            Console.WriteLine("vastag");
        }

        public void Vonalvekony()
        {
            Console.WriteLine("vékony");
        }
    }
}
