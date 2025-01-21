using System;
using System.Text.RegularExpressions;

class OpgaveB18
{
    public static void Kør()
    {
        Console.Clear();

        // Spørg brugeren om en e-mail
        Console.WriteLine("Indtast din e-mailadresse:");
        string email = Console.ReadLine();

        // Regex mønster til at validere e-mail (simpelt, men effektivt)
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        
        // Brug Regex til at matche e-mailen
        if (Regex.IsMatch(email, pattern))
        {
            Console.WriteLine("E-mailen er gyldig.");
        }
        else
        {
            Console.WriteLine("E-mailen er ugyldig. Sørg for at den indeholder '@', '.' og har et gyldigt format.");
        }

        // Afslut programmet
        Console.ReadKey();
    }
}
