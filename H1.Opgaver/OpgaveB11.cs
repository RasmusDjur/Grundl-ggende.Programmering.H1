class OpgaveB11 {

 
    private const string RigtigtBrugernavn = "admin"; // Rigtigt brugernavn
    private const string RigtigtKodeord = "1234";    // Rigtigt kodeord

    public static void Kør()
    {
        Console.Clear();
        Console.WriteLine("Velkommen til Login-Systemet!");

        int forsøgTilbage = 3; // Antal forsøg tilbage
        bool adgangGivet = false;

        while (forsøgTilbage > 0 && !adgangGivet)
        {
            Console.WriteLine("\nIndtast brugernavn: ");
            string brugernavn = Console.ReadLine();

            Console.WriteLine("Indtast adgangskode: ");
            string kodeord = Console.ReadLine();

            if (brugernavn == RigtigtBrugernavn && kodeord == RigtigtKodeord)
            {
                Console.WriteLine("\nAdgang givet! Velkommen, admin!");
                adgangGivet = true;
            }
            else
            {
                forsøgTilbage--;
                Console.WriteLine($"Forkert brugernavn eller adgangskode. Forsøg tilbage: {forsøgTilbage}");
            }
        }

        if (!adgangGivet)
        {
            Console.WriteLine("\nAdgangen er blokeret. Kontakt administratoren for hjælp.");
        }

        Console.WriteLine("\nTryk på en vilkårlig tast for at afslutte...");
        Console.ReadKey();
    }
}


