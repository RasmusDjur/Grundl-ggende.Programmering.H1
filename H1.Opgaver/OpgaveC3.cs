using System;
using System.Collections.Generic;
using System.IO;

namespace C_opgaverP1
{
    internal class OpgaveC3
    {
        // dictionary til at gemme udgifter opdelt på kategorier 
        static Dictionary<string, double> udgifter = new Dictionary<string, double>();
        static double indkomst; // månedlige indkomst
        static string filePath = "budgetHistorik.txt";  // Fil til at gemme historik og prognoser

        // hovedmetode der håndtere brugerens valg i menuen 
        public static void Kør()
        {
            
            while (true)
            {   
                // menu for budgetplanlægning og udgiftssporing 
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
                        return;
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
                udgifter[kategori] = udgift; // gem udgiften i dictionary'en 
            }

            // Gem data til fil
            SaveData();
        }

        // Beregn og vis økonomisk status (overskud/underskud)
        public static void VisØkonomiskStatus()
        {
            Console.Clear();
            double totalUdgift = 0;

            // beregn total udgift ved at summere alle udgifter 
            foreach (var udgift in udgifter.Values)
            {
                totalUdgift += udgift;
            }
            
            // beregn overskud/underskud ved at trække total udgift fra indkomsten 
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

            // Beregn total udgift på samme måde som i VisØkonomiskStatus
            foreach (var udgift in udgifter.Values)
            {
                totalUdgift += udgift;
            }
            
            // beregn overskud/underskud for nuværende måned 
            double overskudUnderskud = indkomst - totalUdgift;

            // vis prognose for de næste 6 måneder 
            for (int i = 1; i <= 6; i++)
            {
                double prognose = overskudUnderskud * i; // // Beregn overskud/underskud for den i'te måned
                Console.WriteLine($"Måned {i}: {prognose} kr.");
            }
            Console.ReadKey();
        }

        // Vis historik fra tekstfil
        public static void VisHistorik()
        {
            Console.Clear();
            
            // tjek om filen eksistere 
            if (File.Exists(filePath))
            {
                var historik = File.ReadAllLines(filePath); // las alle linjer fra filen 
                foreach (var line in historik)
                {
                    Console.WriteLine(line); // vis hver linje fra filen 
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
            // opret en liste med data der skal gemmes i filen 
            List<string> data = new List<string>
            {
                $"Indkomst: {indkomst} kr.",
                $"Udgifter: {string.Join(", ", udgifter)}" // konverter udgifter til en string og tilføj til data
            };

            // gem data til fil (tilføj til filen, hvis den allerede eksistere)
            File.AppendAllLines(filePath, data);
        }
    }
}
