using System;

class OpgaveB8
{

    public static void Kør()
    {
        Console.Clear();
        Console.WriteLine("Velkommen til programmet for løsning af kvadratiske ligninger!");
        Console.WriteLine("En kvadratisk ligning har formen ax^2 + bx + c = 0");
        Console.WriteLine();

        try
        {
            // Indlæs koefficienter a, b og c
            Console.Write("Indtast værdien af a (skal være forskellig fra 0): ");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                throw new ArgumentException("a må ikke være 0 for en kvadratisk ligning.");
            }

            Console.Write("Indtast værdien af b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast værdien af c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Beregn diskriminanten
            double diskriminant = b * b - 4 * a * c;

            Console.WriteLine($"\nDiskriminanten (D) er: {diskriminant}");

            if (diskriminant > 0)
            {
                // To reelle løsninger
                double x1 = (-b + Math.Sqrt(diskriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(diskriminant)) / (2 * a);
                Console.WriteLine($"Der er to reelle løsninger:");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else if (diskriminant == 0)
            {
                // Én reel løsning
                double x = -b / (2 * a);
                Console.WriteLine($"Der er én reel løsning:");
                Console.WriteLine($"x = {x}");
            }
            else
            {
                // Ingen reelle løsninger (to komplekse løsninger)
                double realDel = -b / (2 * a);
                double imaginærDel = Math.Sqrt(-diskriminant) / (2 * a);
                Console.WriteLine($"Der er ingen reelle løsninger. Der er to komplekse løsninger:");
                Console.WriteLine($"x1 = {realDel} + {imaginærDel}i");
                Console.WriteLine($"x2 = {realDel} - {imaginærDel}i");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Fejl: Indtast kun tal som input.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Fejl: {ex.Message}");
        }
        catch (Exception)
        {
            Console.WriteLine("En uventet fejl opstod. Prøv igen.");
        }
        finally
        {
            Console.WriteLine("\nTryk på en vilkårlig tast for at vende tilbage til hovedmenuen...");
            Console.ReadKey();
        }
    }
}
