using System;

class Opgave20
{
    public static void Kør()
    {
        Console.Clear();
       

        // Definer brugernavn og adgangskode
        string korrektBrugernavn = "admin";
        string korrektAdgangskode = "1234";

        // Indlæs brugernavn og adgangskode
        Console.WriteLine("Indtast brugernavn: ");
        string brugernavn = Console.ReadLine();

        Console.WriteLine("Indtast adgangskode: ");
        string adgangskode = Console.ReadLine();

        // Tjek om input matcher de korrekte værdier
        if (brugernavn == korrektBrugernavn && adgangskode == korrektAdgangskode)
        {
            Console.WriteLine("Adgang bekræftet! Du er logget ind.");
        }
        else
        {
            Console.WriteLine("Ugyldigt brugernavn eller adgangskode. Prøv igen.");
        }


        // Afslut programmet
        Console.ReadKey();
    }
}