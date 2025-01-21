using System;

class OpgaveB15
{
    public static void Kør()
    {
        // Opret et array til at gemme udgifterne for hver måned (12 måneder)
        double[] udgifter = new double[12];
        double totalUdgifter = 0;

        Console.Clear();
        Console.WriteLine("Velkommen til det udvidede månedsbudget.");
        Console.WriteLine("Indtast dine udgifter for hver måned.");

        // Brugeren indtaster udgifter for hver måned
        for (int måned = 0; måned < 12; måned++)
        {
            Console.WriteLine($"Indtast udgifter for måned {måned + 1}: ");
            udgifter[måned] = Convert.ToDouble(Console.ReadLine());
            totalUdgifter += udgifter[måned];
        }

        // Beregn gennemsnittet af udgifterne
        double gennemsnit = totalUdgifter / 12;

        // Udskriv resultaterne
        Console.WriteLine("\nDine udgifter for året:");
        for (int måned = 0; måned < 12; måned++)
        {
            Console.WriteLine($"Måned {måned + 1}: {udgifter[måned]:C}");
        }

        Console.WriteLine($"\nSamlede udgifter for året: {totalUdgifter:C}");
        Console.WriteLine($"Gennemsnitlige udgifter pr. måned: {gennemsnit:C}");

        Console.WriteLine("\nTryk på en vilkårlig tast for at afslutte...");
        Console.ReadKey();
    }
}
