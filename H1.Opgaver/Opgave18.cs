using System;

class Opgave18
{
    public static void Kør()
    {
        Console.Clear();


        // Generer et tilfældigt tal mellem 1 og 10
        Random random = new Random();
        int hemmeligtTal = random.Next(1, 11); // Generer et tal mellem 1 og 10

        int brugerGæt = 0;  // Variabel til at gemme brugerens gæt

        // Mens brugerens gæt ikke er korrekt, fortsætter løkken
        while (brugerGæt != hemmeligtTal)
        {
            Console.WriteLine("Gæt et tal mellem 1 og 10:");

            // Læs brugerens input og konverter det til et heltal
            bool erTal = int.TryParse(Console.ReadLine(), out brugerGæt);

            // Hvis inputtet ikke er et tal, spørg igen
            if (!erTal)
            {
                Console.WriteLine("Det var ikke et gyldigt tal, prøv igen.");
                continue; // Hvis det ikke er et tal, fortsæt til næste iteration
            }

            // Giv feedback baseret på brugerens gæt
            if (brugerGæt < hemmeligtTal)
            {
                Console.WriteLine("For lavt, prøv igen.");
            }
            else if (brugerGæt > hemmeligtTal)
            {
                Console.WriteLine("For højt, prøv igen.");
            }
        }

        // Når brugeren gætter det rigtige tal
        Console.WriteLine($"Tillykke! Du gættede det hemmelige tal {hemmeligtTal}.");


        // Afslut programmet
        Console.ReadKey();
    }
}