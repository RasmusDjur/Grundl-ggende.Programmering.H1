class Opgave10
{
    public static void Kør()
    {
        Console.Clear();
    
        // Opret en 2x2 matrix (2 rækker og 2 kolonner)
        int[,] matrix = {
            { 1, 2 },  // Første række
            { 3, 4 }   // Anden række
        };

        // Udskriv matrixens indhold
        Console.WriteLine("Indholdet af matrixen:");
        
        // Brug to for-løkker for at udskrive hver værdi i matrixen
        for (int i = 0; i < 2; i++) // Rækker
        {
            for (int j = 0; j < 2; j++) // Kolonner
            {
                Console.Write(matrix[i, j] + " "); // Udskriv værdi
            }
            Console.WriteLine(); // Gå til næste række
        }

        // Afslut programmet
        Console.ReadKey();
    }
}

