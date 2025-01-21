using System;

class OpgaveB17
{
    public static void Kør()
    {
        Console.Clear();
        Console.WriteLine("Indtast kontakter, og programmet vil sortere dem alfabetisk.");
        
        // Opret et array til at gemme kontakterne
        string[] kontakter = new string[5];  // For eksempel et array med 5 kontakter

        // Brugeren indtaster kontaktpersoner
        for (int i = 0; i < kontakter.Length; i++)  
        {
            Console.WriteLine($"Indtast kontakt {i + 1}: ");
            kontakter[i] = Console.ReadLine();  // Gem input i arrayet
        }

         // Sorter arrayet alfabetisk med dansk kultur
        Array.Sort(kontakter, StringComparer.Create(System.Globalization.CultureInfo.GetCultureInfo("da-DK"), false));


        // Udskriv de sorterede kontakter
        Console.WriteLine("\nKontakterne i alfabetisk rækkefølge:");
        foreach (var kontakt in kontakter)
        {
            Console.WriteLine(kontakt);
        }

        Console.WriteLine("\nTryk på en vilkårlig tast for at afslutte...");
        Console.ReadKey();
    }
}

