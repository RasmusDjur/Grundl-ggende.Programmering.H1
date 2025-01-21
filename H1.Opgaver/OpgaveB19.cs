using System;

class OpgaveB19
{
    public static void Kør()
    {
        Console.Clear();

        // Spørg brugeren om hvor mange Fibonacci-tal de vil have
        Console.WriteLine("Hvor mange Fibonacci-tal vil du vise?");
        int n = Convert.ToInt32(Console.ReadLine());

        // Udskriv Fibonacci-sekvensen
        Console.WriteLine("Fibonacci-sekvensen:");

        int a = 0, b = 1, c;

        // Udskriv de første to tal i sekvensen
        if (n >= 1) Console.Write(a + " ");
        if (n >= 2) Console.Write(b + " ");

        for (int i = 2; i < n; i++)
        {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }

        Console.ReadKey();
    }
}
