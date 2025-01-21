using System;
using System.Collections.Generic;

namespace C_opgaverP1
{
    internal class OpgaveC2
    {
        static List<Medarbejder> medarbejdere = new List<Medarbejder>();

        // Medarbejderklasse
        public class Medarbejder
        {
            public string Navn { get; set; }
            public int Arbejdstimer { get; set; }
            public double Timeløn { get; set; }
            public double Skatteprocent { get; set; }

            public Medarbejder(string navn, int arbejdstimer, double timeløn, double skatteprocent)
            {
                Navn = navn;
                Arbejdstimer = arbejdstimer;
                Timeløn = timeløn;
                Skatteprocent = skatteprocent;
            }

            // Beregn bruttoløn
            public double BeregnBruttoløn() => Arbejdstimer * Timeløn;

            // Beregn nettoløn
            public double BeregnNettoløn() => BeregnBruttoløn() * (1 - Skatteprocent / 100);
        }

        // Start metode for OpgaveC2
        public static void Kør()
        {
            while (true)
            {
                // Vis menu for medarbejderhåndtering
                Console.Clear();
                Console.WriteLine("\n\tMedarbejderhåndtering og Lønberegner");
                Console.WriteLine("\t1. Tilføj Medarbejder");
                Console.WriteLine("\t2. Rediger Medarbejder");
                Console.WriteLine("\t3. Slet Medarbejder");
                Console.WriteLine("\t4. Vis Alle Medarbejdere");
                Console.WriteLine("\t5. Afslut");

                Console.Write("Vælg en mulighed: ");
                string valg = Console.ReadLine();

                // Håndter brugerens valg
                switch (valg)
                {
                    case "1":
                        TilføjMedarbejder();
                        break;
                    case "2":
                        RedigerMedarbejder();
                        break;
                    case "3":
                        SletMedarbejder();
                        break;
                    case "4":
                        VisAlleMedarbejdere();
                        break;
                    case "5":
                        return; // Afslut
                    default:
                        Console.WriteLine("Ugyldigt valg, prøv igen.");
                        break;
                }
            }
        }

        // Tilføj medarbejder
        public static void TilføjMedarbejder()
        {
            Console.Clear();
            Console.WriteLine("Tilføj ny medarbejder");

            Console.Write("Indtast navn: ");
            string navn = Console.ReadLine();
            Console.Write("Indtast arbejdstimer: ");
            int arbejdstimer = int.Parse(Console.ReadLine());
            Console.Write("Indtast timeløn: ");
            double timeløn = double.Parse(Console.ReadLine());
            Console.Write("Indtast skatteprocent: ");
            double skatteprocent = double.Parse(Console.ReadLine());

            Medarbejder nyMedarbejder = new Medarbejder(navn, arbejdstimer, timeløn, skatteprocent);
            medarbejdere.Add(nyMedarbejder);
            Console.WriteLine("Medarbejder tilføjet.");
            Console.ReadKey();
        }

        // Rediger medarbejder
        public static void RedigerMedarbejder()
        {
            Console.Clear();
            Console.Write("Indtast navnet på medarbejderen, du vil redigere: ");
            string navn = Console.ReadLine();

            var medarbejder = medarbejdere.Find(m => m.Navn.Equals(navn, StringComparison.OrdinalIgnoreCase));
            if (medarbejder != null)
            {
                Console.WriteLine("Rediger medarbejderens oplysninger:");
                Console.Write($"Arbejdstimer (nu: {medarbejder.Arbejdstimer}): ");
                medarbejder.Arbejdstimer = int.Parse(Console.ReadLine());

                Console.Write($"Timeløn (nu: {medarbejder.Timeløn}): ");
                medarbejder.Timeløn = double.Parse(Console.ReadLine());

                Console.Write($"Skatteprocent (nu: {medarbejder.Skatteprocent}%): ");
                medarbejder.Skatteprocent = double.Parse(Console.ReadLine());

                Console.WriteLine("Medarbejder opdateret.");
            }
            else
            {
                Console.WriteLine("Medarbejder ikke fundet.");
            }
            Console.ReadKey();
        }

        // Slet medarbejder
        public static void SletMedarbejder()
        {
            Console.Clear();
            Console.Write("Indtast navnet på medarbejderen, du vil slette: ");
            string navn = Console.ReadLine();

            var medarbejder = medarbejdere.Find(m => m.Navn.Equals(navn, StringComparison.OrdinalIgnoreCase));
            if (medarbejder != null)
            {
                medarbejdere.Remove(medarbejder);
                Console.WriteLine("Medarbejder slettet.");
            }
            else
            {
                Console.WriteLine("Medarbejder ikke fundet.");
            }
            Console.ReadKey();
        }

        // Vis alle medarbejdere
        public static void VisAlleMedarbejdere()
        {
            Console.Clear();
            Console.WriteLine("Alle Medarbejdere:");
            if (medarbejdere.Count > 0)
            {
                foreach (var medarbejder in medarbejdere)
                {
                    Console.WriteLine($"Navn: {medarbejder.Navn}");
                    Console.WriteLine($"Arbejdstimer: {medarbejder.Arbejdstimer}");
                    Console.WriteLine($"Timeløn: {medarbejder.Timeløn}");
                    Console.WriteLine($"Bruttoløn: {medarbejder.BeregnBruttoløn()}");
                    Console.WriteLine($"Nettoløn: {medarbejder.BeregnNettoløn()}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Ingen medarbejdere fundet.");
            }
            Console.ReadKey();
        }
    }
}

    


   