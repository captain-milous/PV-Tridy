namespace PV_Tridy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
        }
    }
}