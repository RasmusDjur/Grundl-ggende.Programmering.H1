class Opgave5
{
    public static void Kør()
    {
        Console.Clear();
        // Indlæs alder 
        Console.WriteLine("Indtast en temperatur i Fahrenheit: ");
        double tempFah = Convert.ToDouble(Console.ReadLine());

        double tempCel = (tempFah - 32) / 1.8;
    
        Console.WriteLine($"Resultatet af {tempFah} Fahrenheit er {tempCel:F2} Celsius");
        Console.ReadKey();       
    }
}