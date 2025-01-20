class Opgave4
{
    public static void Kør()
    {
        Console.Clear();
        // Indlæs alder 
        Console.WriteLine("Indtast din alder: ");
        double alder = Convert.ToDouble(Console.ReadLine());

        if (alder >= 18){
            Console.WriteLine("Tillykke du er myndig min ven");
            Console.ReadKey();
        }
        else {
            Console.WriteLine("Du er ikke myndig, hund!");
            Console.ReadKey();
        }
    }
}