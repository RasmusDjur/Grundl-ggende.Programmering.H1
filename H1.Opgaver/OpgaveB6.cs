class OpgaveB6
{
  
    public static void Kør()
    {
        Console.Clear();
        Console.WriteLine("Velkommen til kontaktlisten!");

        // Opret en liste over kontakter
        string[] kontakter = {
            "Anders", "Birgitte", "Carsten", "Dorte", "Erik", 
            "Frederik", "Gitte", "Hans", "Ingrid", "Jens",
            "Karen", "Lars", "Mette", "Niels", "Ole", 
            "Pernille", "Rasmus", "Susanne", "Thomas", "Ulla", 
            "Vibeke", "William", "Xenia", "Yvonne", "Zacharias"
        };

        int kontakterPrSide = 10;
        int totalKontakter = kontakter.Length;
        int totalSider = (int)Math.Ceiling((double)totalKontakter / kontakterPrSide);

        int aktuelSide = 1;

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Side {aktuelSide} af {totalSider}");
            Console.WriteLine("------------------------------");

            // Beregn start- og slutindeks for kontakterne på den aktuelle side
            int startIndeks = (aktuelSide - 1) * kontakterPrSide;
            int slutIndeks = Math.Min(startIndeks + kontakterPrSide, totalKontakter);

            // Udskriv kontakter for den aktuelle side
            for (int i = startIndeks; i < slutIndeks; i++)
            {
                Console.WriteLine($"{i + 1}. {kontakter[i]}");
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Naviger:");
            Console.WriteLine("1. Forrige side");
            Console.WriteLine("2. Næste side");
            Console.WriteLine("3. Afslut");
            Console.Write("Vælg en mulighed: ");
            string valg = Console.ReadLine();

            // Håndter brugerens valg
            if (valg == "1" && aktuelSide > 1)
            {
                aktuelSide--;
            }
            else if (valg == "2" && aktuelSide < totalSider)
            {
                aktuelSide++;
            }
            else if (valg == "3")
            {
                Console.WriteLine("Farvel!");
                break;
            }
            else
            {
                Console.WriteLine("Ugyldigt valg. Prøv igen.");
                Console.ReadKey();
            }
        }
    }
}

    
  
