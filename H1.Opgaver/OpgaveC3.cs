using System;
using System.Collections.Generic;
using System.IO;

namespace C_opgaverP1
{
    internal class OpgaveC3
    {
        static Dictionary<string, double> udgifter = new Dictionary<string, double>();
        static double indkomst;
        static string filePath = "budgetHistorik.txt";  // Fil til at gemme historik og prognoser

        public static void Kør()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Avanceret Budgetplanlægger og Udgiftssporing");
                Console.WriteLine("1. Indtast Indkomst og Udgifter");
                Console.WriteLine("2. Vis Økonomisk Status");
                Console.WriteLine("3. Prognose for de næste 6 måneder");
                Console.WriteLine("4. Vis Historik");
                Console.WriteLine("0. Afslut");
                string valg = Console.ReadLine();

                switch (valg)
                {
                    case "1":
                        IndtastIndkomstOgUdgifter();
                        break;
                    case "2":
                        VisØkonomiskStatus();
                        break;
                    case "3":
                        Prognose();
                        break;
                    case "4":
                        VisHistorik();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg, prøv igen.");
                        break;
                }
            }
        }

        // Indtast indkomst og udgifter opdelt på kategorier
        public static void IndtastIndkomstOgUdgifter()
        {
            Console.Clear();

            // Indtast indkomst
            Console.Write("Indtast din månedlige indkomst: ");
            indkomst = double.Parse(Console.ReadLine());

            // Indtast udgifter opdelt på kategorier
            Console.WriteLine("Indtast dine månedlige udgifter opdelt på kategorier:");
            string[] kategorier = { "Mad", "Transport", "Bolig", "Underholdning", "Øvrige" };
            foreach (var kategori in kategorier)
            {
                Console.Write($"Indtast udgift for {kategori}: ");
                double udgift = double.Parse(Console.ReadLine());
                udgifter[kategori] = udgift;
            }

            // Gem data til fil
            SaveData();
        }

        // Beregn og vis økonomisk status (overskud/underskud)
        public static void VisØkonomiskStatus()
        {
            Console.Clear();
            double totalUdgift = 0;
            foreach (var udgift in udgifter.Values)
            {
                totalUdgift += udgift;
            }

            double overskudUnderskud = indkomst - totalUdgift;
            Console.WriteLine($"Indkomst: {indkomst} kr.");
            Console.WriteLine($"Total Udgift: {totalUdgift} kr.");
            Console.WriteLine($"Økonomisk Status: {(overskudUnderskud >= 0 ? "Overskud" : "Underskud")}");
            Console.WriteLine($"Overskud/Underskud: {overskudUnderskud} kr.");
            Console.ReadKey();
        }

        // Prognose for de næste 6 måneder baseret på nuværende data
        public static void Prognose()
        {
            Console.Clear();
            Console.WriteLine("Prognose for de næste 6 måneder:");
            double totalUdgift = 0;
            foreach (var udgift in udgifter.Values)
            {
                totalUdgift += udgift;
            }

            double overskudUnderskud = indkomst - totalUdgift;
            for (int i = 1; i <= 6; i++)
            {
                double prognose = overskudUnderskud * i;
                Console.WriteLine($"Måned {i}: {prognose} kr.");
            }
            Console.ReadKey();
        }

        // Vis historik fra tekstfil
        public static void VisHistorik()
        {
            Console.Clear();
            if (File.Exists(filePath))
            {
                var historik = File.ReadAllLines(filePath);
                foreach (var line in historik)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Ingen historik fundet.");
            }
            Console.ReadKey();
        }

        // Gem data til fil
        public static void SaveData()
        {
            List<string> data = new List<string>
            {
                $"Indkomst: {indkomst} kr.",
                $"Udgifter: {string.Join(", ", udgifter)}"
            };
            File.AppendAllLines(filePath, data);
        }
    }
}
