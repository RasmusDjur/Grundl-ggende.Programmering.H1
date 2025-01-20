class Opgave9
{
    public static void Kør()
    {
        Console.Clear();
    
        // Opret en array med frugter
        string[] frugter = { "Æble", "Banan", "Appelsin", "Druer", "Mango" };

        // Brug en foreach-løkke til at udskrive alle elementerne i array'et
        Console.WriteLine("Liste over frugter:");
        foreach (string frugt in frugter)
        {
            Console.WriteLine(frugt); // Udskriv hver frugt i array'et
        }

        // Afslut programmet
        Console.ReadKey();
    }
}


       
