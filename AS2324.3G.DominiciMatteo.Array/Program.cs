namespace AS2324._3G.DominiciMatteo.Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matteo Dominici; 3G; 22/02/2024; Esercizio Array");
            Console.WriteLine("Quante persone vuoi inserire?");
            int dim = Convert.ToInt32(Console.ReadLine());
            double[] pesi = new double[dim];
            int[] eta = new int[dim];
            CaricaVettori(ref pesi, ref eta);
        }
        static void CaricaVettori(ref double[] pesi, ref int[] eta)
        {
            foreach (int i in pesi)
            {
                Random rnd = new Random();
                pesi[i] = rnd.Next(50, 101);
                eta[i] = rnd.Next(18, 100);
            }
        }
    }
}

