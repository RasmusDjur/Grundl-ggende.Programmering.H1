using System;

class OpgaveB14
{
    // Metode til beregning af areal og omkreds af en cirkel
    public static void BeregnCirklen(double radius)
    {
        double areal = Math.PI * Math.Pow(radius, 2);
        double omkreds = 2 * Math.PI * radius;
        
        Console.WriteLine($"For en cirkel med radius {radius}:");
        Console.WriteLine($"Areal: {areal:F2}");
        Console.WriteLine($"Omkreds: {omkreds:F2}");
    }

    // Metode til beregning af areal og omkreds af et rektangel
    public static void BeregnRektangel(double bredde, double højde)
    {
        double areal = bredde * højde;
        double omkreds = 2 * (bredde + højde);
        
        Console.WriteLine($"For et rektangel med bredde {bredde} og højde {højde}:");
        Console.WriteLine($"Areal: {areal:F2}");
        Console.WriteLine($"Omkreds: {omkreds:F2}");
    }

    // Hovedmetode som viser menu og vælger figurer
    public static void Kør()
    {
        Console.Clear();
        Console.WriteLine("Vælg en figur:");
        Console.WriteLine("1. Cirklen");
        Console.WriteLine("2. Rektanglet");
        Console.Write("Indtast valg (1 eller 2): ");
        string valg = Console.ReadLine();

        switch (valg)
        {
            case "1":
                Console.Write("Indtast radius af cirklen: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                BeregnCirklen(radius);  // Beregn for cirklen
                break;

            case "2":
                Console.Write("Indtast bredden af rektanglet: ");
                double bredde = Convert.ToDouble(Console.ReadLine());
                Console.Write("Indtast højden af rektanglet: ");
                double højde = Convert.ToDouble(Console.ReadLine());
                BeregnRektangel(bredde, højde);  // Beregn for rektanglet
                break;

            default:
                Console.WriteLine("Ugyldigt valg. Prøv igen.");
                break;
        }
        
        Console.WriteLine("Tryk på en vilkårlig tast for at afslutte...");
        Console.ReadKey();
    }
}


