class Opgave12
{
    public static void Kør()
    {
        Console.Clear();

        // Spørg brugeren om en e-mail
        Console.WriteLine("Indtast din e-mailadresse:");
        string email = Console.ReadLine();

        // Valider om e-mailen indeholder både '@' og '.'
        if (email.Contains("@") && email.Contains("."))
        {
            Console.WriteLine("E-mailen er gyldig.");
        }
        else
        {
            Console.WriteLine("E-mailen er ugyldig. Den skal indeholde både '@' og '.'.");
        }

        // Afslut programmet
        Console.ReadKey();
    }
}

