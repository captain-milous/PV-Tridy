using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Tridy
{
    internal class Trojuhelnik
    {
        private double a;
        private double b;
        private double c;

        public Trojuhelnik()
        {
            this.a = 1;
            this.b = 1;
            this.c = 1;
        }
        public Trojuhelnik(double a, double b, double c) // Trojuhelnikova nerovnost coming soon
        {
            this.a = a;
            this.b = b; 
            this.c = c;
        }

        public bool JeRovnostranny()
        {
            bool answ = false;
            if (this.a == this.b && this.b == this.c)
            {
                answ = true;
            }
            return answ;
        }
        public bool JeRrovnoramenny()
        {
            bool answ = false;
            if(this.a == this.b && this.a != this.c)
            {
                answ = true;
            }
            else if (this.b == this.c && this.b != this.a)
            {
                answ = true;
            }
            else if (this.c == this.a && this.c != this.b)
            {
                answ = true;
            }
            return answ;
        }
        public bool JePravouhly()
        {
            bool answ = false;
            if (this.a * this.a == this.b * this.b + this.c * this.c)
            {
                answ = true;
            }
            else if(this.b * this.b == this.a * this.a + this.c * this.c)
            {
                answ = true;
            }
            else if(this.c * this.c == this.b * this.b + this.a * this.a)
            {
                answ = true;
            } 
             return answ;
        }

    }
}
