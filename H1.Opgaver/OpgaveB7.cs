class OpgaveB7
{

    public static void Kør()
    {
        Console.Clear();
        Console.WriteLine("Velkommen til programmet for brugerdefinerede fejlmeddelelser!");

        try
        {
            // Bed brugeren om at indtaste et tal
            Console.WriteLine("Indtast et positivt tal: ");
            double tal = Convert.ToDouble(Console.ReadLine());

            // Kontroller, om tallet er negativt
            if (tal < 0)
            {
                throw new ArgumentException("Du kan ikke beregne kvadratroden af et negativt tal."); // Brugertilpasset fejl
            }

            // Beregn kvadratrod
            double resultat = Math.Sqrt(tal);
            Console.WriteLine($"Kvadratroden af {tal} er {resultat}");
        }
        catch (FormatException)
        {
            // Håndter formatfejl (fx hvis input ikke er et tal)
            Console.WriteLine("Fejl: Du skal indtaste et gyldigt tal.");
        }
        catch (ArgumentException ex)
        {
            // Håndter specifik fejl (fx negativt tal)
            Console.WriteLine($"Fejl: {ex.Message}");
        }
        catch (Exception)
        {
            // Håndter alle andre typer fejl
            Console.WriteLine("En uventet fejl opstod. Prøv igen.");
        }
        finally
        {
            Console.WriteLine("Tryk på en vilkårlig tast for at afslutte.");
            Console.ReadKey();
        }
    }
    
}
    
        
