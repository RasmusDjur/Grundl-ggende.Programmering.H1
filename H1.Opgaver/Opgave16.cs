class Opgave16
{
    public static void Kør()
    {
        Console.Clear();

        // Indlæs vægt og højde fra brugeren
        Console.WriteLine("Indtast din vægt (i kg):");
        double vægt = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Indtast din højde (i meter):");
        double højde = Convert.ToDouble(Console.ReadLine());

        // Beregn BMI
        double bmi = vægt / (højde * højde);

        // Udskriv BMI resultat
        Console.WriteLine($"Din BMI er: {bmi:F2}");

        // Vurder BMI
        if (bmi < 18.5)
        {
            Console.WriteLine("Du er undervægtig.");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("Du har normal vægt.");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("Du er overvægtig.");
        }
        else
        {
            Console.WriteLine("Du er svært overvægtig (fedme).");
        }
       
        // Afslut programmet
        Console.ReadKey();
    }
}
