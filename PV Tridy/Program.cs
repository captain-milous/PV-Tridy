namespace PV_Tridy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1.Interval */
            Console.WriteLine("1. Interval");
            Interval interval1 = new Interval(0, 10);
            Interval interval2 = new Interval(10, 5);
            int cislo1 = 4;
            bool zetej = interval1.JeVIntervalu(cislo1);
            if(zetej){
                Console.WriteLine("Cislo " + cislo1 + " je v " + interval1);
            } else
            {
                Console.WriteLine("Cislo " + cislo1 + " neni v " + interval1);
            }
            zetej = interval2.JeVIntervalu(cislo1);
            if (zetej)
            {
                Console.WriteLine("Cislo " + cislo1 + " je v " + interval2);
            }
            else
            {
                Console.WriteLine("Cislo " + cislo1 + " neni v " + interval2);
            }
            Interval interval3 = new Interval(11, 15);
            //interval1.ZjistiPrunik(interval1, interval2);

            /* 2. Primka */
            Console.WriteLine();
            Console.WriteLine("2. Primka");
            Primka primka1 = new Primka(0, 0, 0, 1);
            double delka1 = primka1.Delka();
            Primka primka2 = new Primka(10.1, 8.3, 18.9, 19.5);
            double delka2 = primka2.Delka();
            Console.WriteLine("Primka 1 ma delku " + delka1);
            Console.WriteLine("Primka 2 ma delku " + delka2);

            /* 3. Trojuhelnik */
            Console.WriteLine();
            Console.WriteLine("3. Trojuhelnik");
            Trojuhelnik t1 = new Trojuhelnik(6, 6, 6); //Rovnostranny
            Trojuhelnik t2 = new Trojuhelnik(9, 6, 9); //Rovnoramenny
            Trojuhelnik t3 = new Trojuhelnik(3, 4, 5); //Pravouhly
            Trojuhelnik t4 = new Trojuhelnik(17, 12, 21); //trojuhelnik
            /* nefunkcni
            if (t1.JeRovnostranny)
            {
                Console.WriteLine("Trojuhelnik je rovnostranny");
            }*/

            /* 4. Potravina */
            Console.WriteLine();
            Console.WriteLine("4. Potravina");
            Potravina p1 = new Potravina("Brambora", 50, 210, "kj");
            Potravina p2 = new Potravina("Kobliha", 40, 155, "kcal");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            p1 = p1.ZmenJednotky();
            p2 = p2.ZmenJednotky();
            Console.WriteLine();
            Console.WriteLine(p1);
            Console.WriteLine(p2);


            Console.WriteLine();
            Console.WriteLine("End");
        }
    }
}