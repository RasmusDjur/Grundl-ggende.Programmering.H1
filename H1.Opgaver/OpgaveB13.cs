class OpgaveB13
{
    public static void Kør()
    {
        Console.Clear();
        Console.WriteLine("** Grundlæggende Brug af Git og GitHub til Versionering **");
        Console.WriteLine();
        
        Console.WriteLine("1. Initialiser Git-repository");
        Console.WriteLine("   - Åbn GitHub Desktop -> File > New Repository -> Vælg projektmappe -> Create Repository");
        Console.WriteLine();
        
        Console.WriteLine("2. Lav en ændring");
        Console.WriteLine("   - Foretag ændring i koden (f.eks. opdater metode eller ret fejl).");
        Console.WriteLine();
        
        Console.WriteLine("3. Commit ændringer");
        Console.WriteLine("   - Skriv en kort beskrivelse af ændringen i kommentarfeltet:");
        Console.WriteLine("     Eksempler på kommentarer:");
        Console.WriteLine("     - \"Lavet en metode til at beregne BMI\"");
        Console.WriteLine("     - \"Rettet fejl i lommeregneren\"");
        Console.WriteLine("   - Klik på Commit to main.");
        Console.WriteLine();
        
        Console.WriteLine("4. Push ændringer til GitHub");
        Console.WriteLine("   - Klik på Push origin for at gemme ændringer online.");
        Console.WriteLine();
        
        Console.WriteLine("5. Eksempel på kommentarer");
        Console.WriteLine("   - Før commit: \"Initial commit: Lommeregner til addition og subtraktion.\"");
        Console.WriteLine("   - Efter commit: \"Tilføjet støtte for multiplikation og division.\"");
        Console.WriteLine();
        
        Console.WriteLine("Tryk på en vilkårlig tast for at vende tilbage til menuen...");
        Console.ReadKey();
    }
}
