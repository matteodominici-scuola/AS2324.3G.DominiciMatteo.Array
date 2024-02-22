namespace AS2324._3G.DominiciMatteo.Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matteo Dominici; 3G; 22/02/2024; Esercizio Array");
            Console.WriteLine("Quante persone vuoi inserire?");
            int numPersone = Convert.ToInt32(Console.ReadLine());
            double[] pesi = new double[numPersone];
            int[] eta = new int[numPersone];
            double min = 0;
            double max = 0;
            double media = 0;
            CaricaVettori(ref pesi, ref eta);
            Statistiche(ref pesi, ref media, ref min, ref max);
            Console.WriteLine($"Media pesi: {media}");
            Console.WriteLine($"Peso minimo: {min}");
            Console.WriteLine($"Peso massimo: {max}");
        }
        static void CaricaVettori(ref double[] pesi, ref int[] eta)
        {
            Random rnd = new Random();
            for(int i= 0; i < pesi.Length; i++)
            {
                pesi[i] = rnd.Next(50, 101);
                eta[i] = rnd.Next(18, 100);
            }
        }
        static void Statistiche(ref double[] pesi, ref double media, ref double min, ref double max)
        {
            double sommaPesi = 0;
            min = pesi[0];
            max = pesi[0];
            foreach(double peso in pesi)
            {
                sommaPesi += peso;
                if (peso > max)
                {
                    max = peso;
                }
                if (peso < min)
                {
                    min = peso;
                }
            }
            media = sommaPesi / pesi.Length;
        }
    }
}

