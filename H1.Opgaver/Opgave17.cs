using System;

class Opgave17
{
    public static void Kør()
    {
        Console.Clear();
        // Indlæs navn og alder fra brugeren
        Console.WriteLine("Indtast dit navn:");
        string navn = Console.ReadLine();

        Console.WriteLine("Indtast din alder:");
        int alder = Convert.ToInt32(Console.ReadLine());

        // Formatér og udskriv den formaterede besked
        string besked = $"Hej, mit navn er {navn} og jeg er {alder} år gammel.";
        Console.WriteLine(besked);

        // Afslut programmet
        Console.ReadKey();
    }
}
