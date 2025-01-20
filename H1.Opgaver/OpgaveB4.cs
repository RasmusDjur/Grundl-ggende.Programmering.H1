class OpgaveB4
{
        

        // Metode til at konvertere dollars til danske kroner
        public static double KonverterUSDtilDKK(double beløbUSD)
        {
        double konverteringsrate = 7.5; // Konverteringsrate (1 USD = 7.5 DKK)
        return beløbUSD * konverteringsrate; // Returner konverteret beløb
        }

        public static void Kør()
        {
            Console.Clear();
            Console.WriteLine("Valutakonvertering: Dollars til Danske Kr.");

            // Indlæs beløb i dollars
            Console.WriteLine("Indtast beløbet i USD: ");
            double beløbUSD = Convert.ToDouble(Console.ReadLine());

            // Konverter beløbet til danske kroner ved at kalde metoden
            double beløbDKK = KonverterUSDtilDKK(beløbUSD);

            // Udskriv resultatet
            Console.WriteLine($"{beløbUSD} USD er lig med {beløbDKK} DKK.");

            Console.WriteLine("Tryk på en vilkårlig tast for at afslutte.");
            Console.ReadKey();
        }
}


      

