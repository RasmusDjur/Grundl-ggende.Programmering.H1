namespace C_opgaverP1
{
    internal class Opgave21
    {
        public static void Kør()
        {
            while (true)
            {
                //udskriv hovedmenuen 
                Console.Clear();
               
                Console.WriteLine("\n\tVælg en Opgavetype (skriv tallet)");
                Console.WriteLine();
                Console.WriteLine("\t1. \tAvanceret Lommeregner");
                Console.WriteLine("\t2. \tList Sortering");
                Console.WriteLine("\t3. \tPalindrome Checker");
                Console.WriteLine("\t4. \tValutakonvertering");
                Console.WriteLine("\t5. \tGæt-nummer-spil med Tilbagekobling");
                Console.WriteLine("\t6. \tPagination af Kontakter");
                Console.WriteLine("\t7. \tBrugerdefinerede Fejlmeddelelser");
                Console.WriteLine("\t8. \tMatematiske Ligninger");
                Console.WriteLine("\t9. \tBankkonto-Simulator");
                Console.WriteLine("\t11. \tLogik-baseret Login");
                Console.WriteLine("\t12. \tAnalysering af Tekstfiler");
                Console.WriteLine("\t13. \tVersionering af Programændringer");
                Console.WriteLine("\t14. \tGeometriske Beregninger");
                Console.WriteLine("\t15. \tUdvidet Månedsbudget");
                Console.WriteLine("\t16. \tFilter for Tal Rækkefølge");
                Console.WriteLine("\t17. \tSorter Kontakter Alfabetisk");
                Console.WriteLine("\t18. \tE-mail Validering med Regex");
                Console.WriteLine("\t19. \tFibonacci Sekvens");
                Console.WriteLine("\t0. \tAfslut");

                //læs brugerens valg 
                string valg = Console.ReadLine();


                //håndtere brugeres valg 
                switch (valg)
                {
                case "1":
                    OpgaveB1.Kør();
                    break;
                case "2":
                    OpgaveB2.Kør();
                    break;
                case "3":
                    OpgaveB3.Kør();
                    break;
                case "4":
                    OpgaveB4.Kør();
                    break;
                case "5":
                    OpgaveB5.Kør();
                    break;
                case "6":
                    OpgaveB6.Kør();
                    break;
                case "7":
                    OpgaveB7.Kør();
                    break;
                case "8":
                    OpgaveB8.Kør();
                    break;
                case "9":
                    OpgaveB9.Kør();
                    break;
                case "11":
                    OpgaveB11.Kør();
                    break;
                case "12":
                    OpgaveB12.Kør();
                    break;
                case "13":
                    OpgaveB13.Kør();
                    break;
                case "14":
                    OpgaveB14.Kør();
                    break;
                case "15":
                    OpgaveB15.Kør();
                    break;
                case "16":
                    OpgaveB16.Kør();
                    break;
                case "17":
                    OpgaveB17.Kør();
                    break;
                case "18":
                    OpgaveB18.Kør();
                    break;
                case "19":
                    OpgaveB19.Kør();
                    break;
                case "0":
                    Console.Clear();
                    Console.WriteLine("Farvel!");
                    return;
                default:
                    Console.WriteLine("Ugyldigt valg, prøv igen.");
                    break;
                }
            }
        }
    }
}

