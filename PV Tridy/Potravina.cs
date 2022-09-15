using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Tridy
{
    internal class Potravina
    {
        private string nazev;
        private double hmot; // gramy
        private double engHod;
        private string engJedn; // kcal nebo kj

        public Potravina()
        {
            this.nazev = "NoName";
            this.hmot = 0;
            this.engHod = 0;
            this.engJedn = "kcal";
        }
        public Potravina(string nazev, double hmot, double engHod, string engJedn)
        {
            this.nazev = nazev;
            this.hmot = hmot;
            this.engHod = engHod;
            this.engJedn = engJedn;
        }
        public string Nazev
        {
            get { return this.nazev; }
            set { this.nazev = value; }
        }
        public double Hmot 
        { 
            get { return this.hmot; } 
            set { this.hmot = value; } 
        }
        public double EngHod
        {
            get { return this.engHod; }
            set { this.engHod = value; }
        }
        public string EngJedn
        {
            get { return this.engJedn; }
            set { this.engJedn = value; }
        }
        public override string ToString()
        {
            return this.nazev+" o hmotnosti "+this.hmot+" gramů, má energetickou hodnotu "+this.engHod+" "+this.engJedn;
        }

        public Potravina? ZmenJednotky()
        {
            Potravina potravina2 = new Potravina();
            potravina2.Nazev = this.nazev;
            potravina2.Hmot = this.Hmot;
            if(this.EngJedn == "kcal")
            {
                potravina2.EngHod = this.EngHod * 4.2;
                potravina2.EngJedn = "kj";
            } else if (this.EngJedn == "kj")
            {
                potravina2.EngHod = this.EngHod / 4.2;
                potravina2.EngJedn = "kcal";
            }
            else
            {
                potravina2.EngHod = this.EngHod;
                potravina2.EngJedn = this.EngJedn;
            }
                return potravina2;
        }

    }
}
