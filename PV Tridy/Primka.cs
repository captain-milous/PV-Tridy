using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Tridy
{
    internal class Primka
    {
        private double ax;
        private double ay;
        private double bx;
        private double by;

        public Primka()
        {
            this.ax = 0;
            this.ay = 0;
            this.bx = 0;
            this.by = 0;
        }
        public Primka(double ax, double ay, double bx, double by)
        {
            this.ax = ax;
            this.ay = ay;
            this.bx = bx;
            this.by = by;
        }
        public double Ax { 
            get { return ax; } 
            set { ax = value; }
        }
        public double Ay
        {
            get { return ay; }
            set { ay = value; }
        }
        public double Bx
        {
            get { return bx; }
            set { bx = value; }
        }
        public double By
        {
            get { return by; }
            set { by = value; }
        }

        public double Delka()
        {
            double delka = 0;
            double x = bx - ax;
            double y = by - ay;
            delka = Math.Round(Math.Sqrt(x * x + y * y), 2);
            return delka;
        }
    }
}
