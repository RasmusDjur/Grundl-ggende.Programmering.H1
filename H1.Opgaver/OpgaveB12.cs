using System;
using System.IO;

class OpgaveB12
{
    public static void Kør()
    {
        Console.Clear();
        Console.WriteLine("Velkommen til Tekstfil Analyseren!");

        // Spørg brugeren om filens sti
        Console.WriteLine("Indtast stien til tekstfilen, du vil analysere:");
        string filsti = Console.ReadLine();

        try
        {
            // Læs hele filens indhold
            string tekst = File.ReadAllText(filsti);

            // Del teksten op i ord baseret på mellemrum
            string[] ord = tekst.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            // Tæl ordene
            int antalOrd = ord.Length;

            Console.WriteLine($"\nFilen indeholder {antalOrd} ord.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Fejl: Filen blev ikke fundet. Kontroller stien og prøv igen.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"En fejl opstod: {ex.Message}");
        }

        Console.WriteLine("\nTryk på en vilkårlig tast for at vende tilbage til hovedmenuen...");
        Console.ReadKey();
    }
}
