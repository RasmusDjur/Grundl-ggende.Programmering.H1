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
                Console.WriteLine("\t5. \tValutakonvertering");
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

