using System;
using System.Collections.Generic;
using System.IO;

namespace C_opgaverP1
{
    internal class OpgaveC4
    {
        public static void Kør()
        {
            // Indlæs bøger fra fil
            LibrarySystem.LoadBooks();

            while (true)
            {
                // Udskriv hovedmenuen for bibliotekssystemet
                Console.Clear();
                Console.WriteLine("\n\tBiblioteksstyring:");
                Console.WriteLine("\t1. Se bøger");
                Console.WriteLine("\t2. Lån en bog");
                Console.WriteLine("\t3. Returner en bog");
                Console.WriteLine("\t0. Tilbage til hovedmenuen");

                // Læs brugerens valg
                string valg = Console.ReadLine();

                // Håndter brugerens valg
                switch (valg)
                {
                    case "1":
                        LibrarySystem.ShowBooks();
                        break;
                    case "2":
                        LibrarySystem.LoanBook();
                        break;
                    case "3":
                        LibrarySystem.ReturnBook();
                        break;
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Tilbage til hovedmenuen.");
                        return;
                    default:
                        Console.WriteLine("Ugyldigt valg, prøv igen.");
                        break;
                }
            }
        }
    }

    // Biblioteksstyringssystem
    public static class LibrarySystem
    {
        static List<Book> books = new List<Book>();
        static string filePath = "library_books.txt";  // Filen hvor bøgerne gemmes

        public static void LoadBooks()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("Ingen eksisterende bøger blev fundet. Opretter en ny fil og tilføjer testbøger.");
                    CreateSampleBooks();  // Opret testbøger, hvis filen ikke findes
                }
                else
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (var line in lines)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length == 4)
                        {
                            string title = parts[0];
                            long isbn = long.Parse(parts[1]);
                            bool isBorrowed = bool.Parse(parts[2]);
                            string borrower = parts[3];

                            books.Add(new Book { Title = title, ISBN = isbn, IsBorrowed = isBorrowed, Borrower = borrower });
                        }
                    }

                    Console.WriteLine("Bøgerne er blevet indlæst fra filen.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fejl ved indlæsning af bøger: {ex.Message}");
            }
        }

        public static void CreateSampleBooks()
        {
            books.Add(new Book { Title = "The Great Gatsby", ISBN = 9780743273565, IsBorrowed = false, Borrower = "" });
            books.Add(new Book { Title = "To Kill a Mockingbird", ISBN = 9780061120084, IsBorrowed = false, Borrower = "" });
            books.Add(new Book { Title = "1984", ISBN = 9780451524935, IsBorrowed = false, Borrower = "" });
            books.Add(new Book { Title = "Moby-Dick", ISBN = 9781503280786, IsBorrowed = false, Borrower = "" });
            books.Add(new Book { Title = "Pride and Prejudice", ISBN = 9781503290563, IsBorrowed = false, Borrower = "" });

            SaveBooks();
            Console.WriteLine("Testbøger er blevet oprettet og gemt.");
        }

        public static void SaveBooks()
        {
            List<string> lines = new List<string>();

            foreach (var book in books)
            {
                string line = $"{book.Title},{book.ISBN},{book.IsBorrowed},{book.Borrower}";
                lines.Add(line);
            }

            try
            {
                File.WriteAllLines(filePath, lines);
                Console.WriteLine("Bøgerne er blevet gemt i filen.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fejl ved gemning af bøger til fil: {ex.Message}");
            }
        }

        // Vis bøgerne
        public static void ShowBooks()
        {
            Console.Clear();
            Console.WriteLine("Liste over bøger:");

            foreach (var book in books)
            {
                string status = book.IsBorrowed ? $"Lånt ud til: {book.Borrower}" : "Ledig";
                Console.WriteLine($"{book.Title} (ISBN: {book.ISBN}) - {status}");
            }

            Console.WriteLine("\nTryk på en tast for at fortsætte...");
            Console.ReadKey();
        }

        // Lån en bog
        public static void LoanBook()
        {
            Console.Clear();

            // Vis bøgerne først, så brugeren kan vælge ISBN
            ShowBooks();

            // Læs brugerens ISBN input
            Console.Write("\nIndtast ISBN på bogen, du vil låne: ");
            string input = Console.ReadLine();

            // Tjek om input er tomt
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Du skal indtaste et ISBN.");
                Console.WriteLine("Tryk på en tast for at fortsætte...");
                Console.ReadKey();
                return;
            }

            // Prøv at konvertere input til et ISBN (long)
            if (!long.TryParse(input, out long isbn))
            {
                Console.WriteLine("Ugyldigt ISBN. Sørg for, at du indtaster et korrekt tal.");
                Console.WriteLine("Tryk på en tast for at fortsætte...");
                Console.ReadKey();
                return;
            }

            var book = books.Find(b => b.ISBN == isbn);

            if (book != null)
            {
                if (book.IsBorrowed)
                {
                    Console.WriteLine("Denne bog er allerede lånt ud.");
                }
                else
                {
                    Console.Write("Indtast dit navn: ");
                    string borrower = Console.ReadLine();

                    book.IsBorrowed = true;
                    book.Borrower = borrower;

                    SaveBooks();
                    Console.WriteLine($"Du har lånt '{book.Title}'.");
                }
            }
            else
            {
                Console.WriteLine("Bog ikke fundet.");
            }

            Console.WriteLine("\nTryk på en tast for at fortsætte...");
            Console.ReadKey();
        }

        // Returner en bog
        public static void ReturnBook()
        {
            Console.Clear();
            Console.Write("Indtast ISBN på bogen, du vil returnere: ");
            string input = Console.ReadLine();

            // Tjek om input er tomt
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Du skal indtaste et ISBN.");
                Console.WriteLine("Tryk på en tast for at fortsætte...");
                Console.ReadKey();
                return;
            }

            // Prøv at konvertere input til et ISBN (long)
            if (!long.TryParse(input, out long isbn))
            {
                Console.WriteLine("Ugyldigt ISBN. Sørg for, at du indtaster et korrekt tal.");
                Console.WriteLine("Tryk på en tast for at fortsætte...");
                Console.ReadKey();
                return;
            }

            var book = books.Find(b => b.ISBN == isbn);

            if (book != null)
            {
                if (!book.IsBorrowed)
                {
                    Console.WriteLine("Denne bog er ikke lånt ud.");
                }
                else
                {
                    book.IsBorrowed = false;
                    book.Borrower = "";

                    SaveBooks();
                    Console.WriteLine($"Du har returneret '{book.Title}'.");
                }
            }
            else
            {
                Console.WriteLine("Bog ikke fundet.");
            }

            Console.WriteLine("\nTryk på en tast for at fortsætte...");
            Console.ReadKey();
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public long ISBN { get; set; }
        public bool IsBorrowed { get; set; }
        public string Borrower { get; set; }
    }
}


