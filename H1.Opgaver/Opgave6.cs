class Opgave6
{
    public static void Kør()
    {
      Console.Clear();
      Console.WriteLine("Velkommen til lommeregneren");

      try {
        // Indlæs 1 tal 
        Console.WriteLine("Indtast det første tal: ");
        double tal1 = Convert.ToDouble(Console.ReadLine());

        // Indlæs 2 tal 
        Console.WriteLine("Indtast det første tal: ");
        double tal2 = Convert.ToDouble(Console.ReadLine());

        // Vælg Operation 
        Console.WriteLine("Vælg en operation:");
            Console.WriteLine("1. Plus (+)");
            Console.WriteLine("2. Minus (-)");
            Console.WriteLine("3. Gange (*)");
            Console.WriteLine("4. Division (/)");
            Console.Write("Indtast dit valg: ");
            string valg = Console.ReadLine();

            // Udfør beregningen
            double resultat = 0;
            bool gyldigOperation = true;

        switch (valg){
            case "1":
                resultat = tal1 + tal2;
                Console.WriteLine($"Resultatet af {tal1} + {tal2} = {resultat}");
                break;
            case "2":
                resultat = tal1 - tal2;
                Console.WriteLine($"Resultatet af {tal1} - {tal2} = {resultat}");
                break;
            case "3":
                resultat = tal1 * tal2;
                Console.WriteLine($"Resultatet af {tal1} * {tal2} = {resultat}");
                break;
            case "4":
                    if (tal2 != 0)
                    {
                        resultat = tal1 / tal2;
                        Console.WriteLine($"Resultatet af {tal1} / {tal2} = {resultat}");
                    }
                    else
                    {
                        Console.WriteLine("Fejl: Division med 0 er ikke tilladt.");
                    }
                    break;
            default:
            gyldigOperation = false;
                    Console.WriteLine("Ugyldigt valg. Prøv igen.");
                    break;
        }
        if (gyldigOperation)
            {
                Console.WriteLine();
                Console.WriteLine("Tryk på en vilkårlig tast for at vende tilbage til hovedmenuen...");
                Console.ReadKey();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Fejl: Du skal indtaste et gyldigt tal.");
            Console.WriteLine("Tryk på en vilkårlig tast for at vende tilbage til hovedmenuen...");
            Console.ReadKey();
        }


      }
       
}
