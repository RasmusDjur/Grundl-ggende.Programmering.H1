class OpgaveB2
{
    public static void Kør()
    {
        Console.Clear();

        // Opret et array med tilfældige tal
        int[] talArray = { 34, 12, 89, 23, 55, 67, 7, 99, 42 };

        // Udskriv den oprindelige array
        Console.WriteLine("Oprindeligt array:");
        foreach (int tal in talArray)
        {
            Console.Write(tal + " ");
        }
        Console.WriteLine(); // Linjeskift

        // Sorter arrayet
        Array.Sort(talArray);

        // Udskriv den sorterede array
        Console.WriteLine("Sorterede array:");
        foreach (int tal in talArray)
        {
            Console.Write(tal + " ");
        }

        Console.WriteLine(); // Linjeskift
        Console.WriteLine("Tryk på en vilkårlig tast for at afslutte.");
        Console.ReadKey();
    }
}


      



