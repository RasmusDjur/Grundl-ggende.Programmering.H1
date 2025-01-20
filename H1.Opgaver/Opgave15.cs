class Opgave15
{
    public static void Kør()
    {
        Console.Clear();

        // Opret et array til at gemme tre tal
        int[] tal = new int[3];

         // Indlæs 1 tal 
        Console.WriteLine("Indtast det første tal: ");
        tal[0] = Convert.ToInt32(Console.ReadLine());

        // Indlæs 2 tal 
        Console.WriteLine("Indtast det første tal: ");
        tal[1] = Convert.ToInt32(Console.ReadLine());

         // Indlæs 3 tal 
        Console.WriteLine("Indtast det første tal: ");
        tal[2] = Convert.ToInt32(Console.ReadLine());

        Array.Sort(tal);

         // Udskriv de tre tal i stigende rækkefølge
        Console.WriteLine("Tallene i stigende rækkefølge:");
        foreach (int t in tal)
        {
            Console.WriteLine(t);
        }



       
        // Afslut programmet
        Console.ReadKey();
    }
}
