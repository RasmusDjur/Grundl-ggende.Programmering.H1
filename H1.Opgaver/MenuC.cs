namespace C_opgaverP1
{
    internal class Opgave22
    {
        public static void Kør()
        {
            while (true)
            {
                //udskriv hovedmenuen 
                Console.Clear();
               
                Console.WriteLine("\n\tVælg en Opgavetype (skriv tallet)");
                Console.WriteLine();
                Console.WriteLine("\t1. \tAvanceret Telefonbog med Søge-, Sorterings-og Filtreringsfunktioner");
                Console.WriteLine("\t2. \tPersonalehåndtering og Lønberegner");
                Console.WriteLine("\t3. \tAvanceret Budgetplanlægger og Udgiftssporing");
                Console.WriteLine("\t4. \tBiblioteksstyring med Ud-og Indlånsfunktionalitet");
                Console.WriteLine("\t0. \tAfslut");

                //læs brugerens valg 
                string valg = Console.ReadLine();


                //håndtere brugeres valg 
                switch (valg)
                {
                case "1":
                    OpgaveC1.Kør();
                    break;
                case "2":
                    OpgaveC2.Kør();
                    break;
                case "3":
                    OpgaveC3.Kør();
                    break;
                case "4":
                    OpgaveC4.Kør();
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