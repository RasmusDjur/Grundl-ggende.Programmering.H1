class Opgave3
{
    public static void Kør()
    {
      Console.Clear();
      Console.WriteLine("Velkommen til lommeregneren");

        double resultat = 0;
      
        // Indlæs 1 tal 
        Console.WriteLine("Indtast det første tal: ");
        double tal1 = Convert.ToDouble(Console.ReadLine());

        // Indlæs 2 tal 
        Console.WriteLine("Indtast det første tal: ");
        double tal2 = Convert.ToDouble(Console.ReadLine());

        // Vælg Operation 
        resultat = tal1 + tal2;
        Console.WriteLine($"Resultatet af {tal1} + {tal2} = {resultat}");
        resultat = tal1 - tal2;
        Console.WriteLine($"Resultatet af {tal1} - {tal2} = {resultat}");
        resultat = tal1 * tal2;
        Console.WriteLine($"Resultatet af {tal1} * {tal2} = {resultat}");
        resultat = tal1 / tal2;
        Console.WriteLine($"Resultatet af {tal1} / {tal2} = {resultat}");
       
        Console.ReadKey();
    }
       
}
