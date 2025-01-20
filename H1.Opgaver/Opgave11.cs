class Opgave11
{
    public static void Kør()
    {
        Console.Clear();

        // Opret en konstant for moms (25%)
        const double momsSats = 0.25; // Moms-satsen er 25%

        // Indlæs en pris fra brugeren
        Console.WriteLine("Indtast prisen uden moms:");
        double prisUdenMoms = Convert.ToDouble(Console.ReadLine());

        // Beregn momsbeløbet
        double moms = prisUdenMoms * momsSats;

        // Beregn den samlede pris inkl. moms
        double prisMedMoms = prisUdenMoms + moms;

        // Udskriv resultatet
        Console.WriteLine($"Prisen uden moms: {prisUdenMoms} DKK");
        Console.WriteLine($"Momsbeløb (25%): {moms} DKK");
        Console.WriteLine($"Samlet pris inkl. moms: {prisMedMoms} DKK");

        // Afslut programmet
        Console.ReadKey();
    }
}

        

