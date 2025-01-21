// See https://aka.ms/new-console-template for more information
namespace C_opgaverP1
{
    internal class hovedMenu
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //udskriv hovedmenuen 
                Console.Clear();
               
                Console.WriteLine("\n\tVælg en Opgavetype (skriv tallet)");
                Console.WriteLine();
                Console.WriteLine("\t1. \tHej Verden");
                Console.WriteLine("\t2. \tVariable");
                Console.WriteLine("\t3. \tMatematiske Operationer");
                Console.WriteLine("\t4. \tIf-else Struktur med Alder");
                Console.WriteLine("\t5. \tGrader Fahrenheit til Celsius");
                Console.WriteLine("\t6. \tLommeregner");
                Console.WriteLine("\t7. \tBrugerdefinerede Metoder");
                Console.WriteLine("\t8. \tLoop Eksempel");
                Console.WriteLine("\t9. \tSimple Arrays");
                Console.WriteLine("\t10. \tMulti-dimensionelle Arrays");
                Console.WriteLine("\t11. \tKonstanter");
                Console.WriteLine("\t12. \tE-mail Validering");
                Console.WriteLine("\t15. \tTal Rækkefølge");
                Console.WriteLine("\t16. \tGrundlæggende BMI-beregner");
                Console.WriteLine("\t17. \tString Formattering");
                Console.WriteLine("\t18. \tTalgenkendelse med Løkke");
                Console.WriteLine("\t19. \tGrunding af Versionsstyring");
                Console.WriteLine("\t20. \tBasis Login System");
                Console.WriteLine("\t21. \tB Rutinerede Opgaver");
                Console.WriteLine("\t22. \tC Rutinerede Opgaver");
                Console.WriteLine("\t0. \tAfslut");

                //læs brugerens valg 
                string valg = Console.ReadLine();


                //håndtere brugeres valg 
                switch (valg)
                {
                case "1":
                    Opgave1.Kør();
                    break;
                case "2":
                    Opgave2.Kør();
                    break;
                case "3":
                    Opgave3.Kør();
                    break;
                case "4":
                    Opgave4.Kør();
                    break;
                case "5":
                    Opgave5.Kør();
                    break;
                case "6":
                    Opgave6.Kør();
                    break;
                case "7":
                    Opgave7.Kør();
                    break;
                case "8":
                    Opgave8.Kør();
                    break;
                case "9":
                    Opgave9.Kør();
                    break;
                case "10":
                    Opgave10.Kør();
                    break;
                case "11":
                    Opgave11.Kør();
                    break;
                case "12":
                    Opgave12.Kør();
                    break;
                case "15":
                    Opgave15.Kør();
                    break;
                case "16":
                    Opgave16.Kør();
                    break;
                case "17":
                    Opgave17.Kør();
                    break;
                case "18":
                    Opgave18.Kør();
                    break;
                case "19":
                    Opgave19.Kør();
                    break;
                case "20":
                    Opgave20.Kør();
                    break;
                case "21":
                    Opgave21.Kør();
                    break;
                case "22":
                    Opgave22.Kør();
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

