
class OpgaveB3
{
    public static void Kør()
    {
        Console.Clear();
        
        
        Console.Clear();
        Console.WriteLine("Tjekker om en sætning er et palindrom.");

        // Indlæs brugerens sætning
        Console.WriteLine("Indtast en sætning: ");
        string input = Console.ReadLine();

        // Fjern mellemrum og tegnsætning, og konverter til små bogstaver
        string rensetInput = new string(input
                                        .Where(c => Char.IsLetterOrDigit(c))  // Behold kun bogstaver og tal
                                        .Select(c => Char.ToLower(c))        // Konverter til små bogstaver
                                        .ToArray());

        // Vend den rensede sætning
        string reversedInput = new string(rensetInput.Reverse().ToArray());

        // Tjek om sætningen er et palindrom
        if (rensetInput == reversedInput)
        {
            Console.WriteLine("Sætningen er et palindrom.");
        }
        else
        {
            Console.WriteLine("Sætningen er ikke et palindrom.");
        }

        Console.WriteLine("Tryk på en vilkårlig tast for at afslutte.");
        Console.ReadKey();


      
       
    }
}