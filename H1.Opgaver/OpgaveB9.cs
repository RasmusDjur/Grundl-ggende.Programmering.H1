class OpgaveB9 {

 
    private static double saldo = 0; // Global variabel til at holde saldoen

    public static void Kør()
    {
        Console.Clear();
        Console.WriteLine("Velkommen til Bankkonto-Simulatoren!");

        bool kører = true;

        while (kører)
        {
            Console.WriteLine("\nVælg en handling:");
            Console.WriteLine("1. Indsæt penge");
            Console.WriteLine("2. Hæv penge");
            Console.WriteLine("3. Se saldo");
            Console.WriteLine("4. Afslut");
            Console.Write("Indtast dit valg: ");

            string valg = Console.ReadLine();

            switch (valg)
            {
                case "1":
                    IndsætPenge();
                    break;
                case "2":
                    HævPenge();
                    break;
                case "3":
                    VisSaldo();
                    break;
                case "4":
                    kører = false;
                    Console.WriteLine("Farvel! Tak for at bruge Bankkonto-Simulatoren.");
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg. Prøv igen.");
                    break;
            }
        }
    }

    private static void IndsætPenge()
    {
        Console.Write("Indtast beløbet, du vil indsætte: ");
        try
        {
            double beløb = Convert.ToDouble(Console.ReadLine());
            if (beløb > 0)
            {
                saldo += beløb;
                Console.WriteLine($"Du har indsat {beløb:C}. Din nye saldo er {saldo:C}.");
            }
            else
            {
                Console.WriteLine("Fejl: Beløbet skal være større end 0.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Fejl: Indtast et gyldigt tal.");
        }
    }

    private static void HævPenge()
    {
        Console.Write("Indtast beløbet, du vil hæve: ");
        try
        {
            double beløb = Convert.ToDouble(Console.ReadLine());
            if (beløb > 0)
            {
                if (beløb <= saldo)
                {
                    saldo -= beløb;
                    Console.WriteLine($"Du har hævet {beløb:C}. Din nye saldo er {saldo:C}.");
                }
                else
                {
                    Console.WriteLine("Fejl: Du har ikke nok penge på kontoen.");
                }
            }
            else
            {
                Console.WriteLine("Fejl: Beløbet skal være større end 0.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Fejl: Indtast et gyldigt tal.");
        }
    }

    private static void VisSaldo()
    {
        Console.WriteLine($"Din nuværende saldo er {saldo:C}.");
    }
}

    
