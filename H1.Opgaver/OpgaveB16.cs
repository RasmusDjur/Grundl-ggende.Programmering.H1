using System;

class OpgaveB16
{
    public static void Kør()
    {
        Console.Clear();
        Console.WriteLine("Indtast flere tal, og programmet vil vise dem i faldende rækkefølge.");
        
        // Opret et array til at gemme tallene
        int[] tal = new int[5];  // Vi sætter en begrænsning på 5 tal for eksemplet.
        int antalTal = 0;

        // Brugeren indtaster tal
        for (int i = 0; i < tal.Length; i++)
        {
            Console.WriteLine($"Indtast tal {i + 1}: ");
            bool validInput = int.TryParse(Console.ReadLine(), out int talIndtastet);
            
            if (validInput)
            {
                tal[i] = talIndtastet;
                antalTal++;
            }
            else
            {
                Console.WriteLine("Ugyldigt input, prøv igen.");
                i--;  // Giv brugeren en chance for at indtaste tallet korrekt igen
            }
        }

        // Sorter tallene i stigende rækkefølge
        Array.Sort(tal, 0, antalTal);

        // Vend arrayet om, så tallene bliver i faldende rækkefølge
        Array.Reverse(tal, 0, antalTal);

        // Udskriv tallene i faldende rækkefølge
        Console.WriteLine("\nTallene i faldende rækkefølge:");
        for (int i = 0; i < antalTal; i++)
        {
            Console.WriteLine(tal[i]);
        }

        Console.WriteLine("\nTryk på en vilkårlig tast for at afslutte...");
        Console.ReadKey();
    }
}
