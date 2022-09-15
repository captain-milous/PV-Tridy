using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Tridy
{
    internal class Interval
    {
        private int min;
        private int max;

        public Interval(int min, int max)
        {
            if (min <= max)
            {
                this.min = min;
                this.max = max;
            }
            else
            {
                this.min = max;
                this.max = min;
            }
            
        }
        public int Min { 
            get { return min; } 
            set { 
                if(value < max) { 
                    min = value;
                }
            }
        }

        public int Max { 
            get { return max; }
            set
            {
                if (value > min)
                {
                    max = value;
                }
            }
        }

        public override string ToString()
        {
            return "Interval od "+this.min+" do "+this.max;
        }

        public bool JeVIntervalu(int cislo)
        {
            if(cislo > min && cislo<max)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static Interval? ZjistiPrunik(Interval interval1, Interval interval2)
        {
            Interval zjisti = null;
            if(interval1.max >= interval2.min || interval2.max >= min)
            {
                /*
                if(max >= interval2.min)
                {
                    zjisti = new Interval(interval2.min, max);
                }
                if (interval2.max >= min)
                {
                    zjisti = new Interval(min, interval2.max);
                }*/

               return zjisti;
            } else
            {
               return null;
            }
        }
    }
}
