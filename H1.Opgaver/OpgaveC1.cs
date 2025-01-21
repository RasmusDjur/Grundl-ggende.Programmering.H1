using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class OpgaveC1

{
    // liste til at gemme alle kontakter 
    static List<Contact> contacts = new List<Contact>();
    // sti til tekstfilen, hvor kontakterne gemmes/hentes fra 
    static string filePath = "contacts.txt";

    // metode der kører programmet 
    public static void Kør()
    {   
        // indlæs eksisterende kontakter fra filen ved programmets opstart
        LoadContacts();
        // viser menuen indtil brugeren vælger at stoppe 
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Telefonbog");
            Console.WriteLine("1. Tilføj Kontakt");
            Console.WriteLine("2. Søg Kontakt");
            Console.WriteLine("3. Rediger Kontakt");
            Console.WriteLine("4. Slet Kontakt");
            Console.WriteLine("5. Vis Alle Kontakter");
            Console.WriteLine("6. Sorter Kontakter");
            Console.WriteLine("7. Afslut");
            Console.Write("Vælg en mulighed: ");
            string choice = Console.ReadLine();

            // behandler brugerens input 
            switch (choice)
            {
                case "1":
                    AddContact(); // tilføj en kontakt 
                    break;
                case "2":
                    SearchContact(); // søg efter en kontakt
                    break;
                case "3":
                    EditContact(); // rediger en kontakt 
                    break;
                case "4":
                    DeleteContact(); // slet en kontakt 
                    break;
                case "5":
                    DisplayContacts(); // vis alle kontakter 
                    break;
                case "6":
                    SortContacts(); // sorter kontakter alfabetisk 
                    break;
                case "7":
                    exit = true; // afslut programmet 
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg, prøv igen.");
                    break;
            }
        }
        SaveContacts(); // gemmer kontakterne tilbage til filen, når programmet afluttes
    }

    // Kontaktklasse som repræsentere en kontakt 
    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // konstruktor til at oprette en kontakt med navn, email og telefonnummer
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }

    // Indlæs kontakter fra tekstfil
    public static void LoadContacts()
    {
        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(','); // del hver linje op i navn, tellefonnummer og emeail
                if (parts.Length == 3)
                {
                    contacts.Add(new Contact(parts[0], parts[1], parts[2])); // opret kontakt og tilføj til listen 
                }
            }
        }
    }

    // Gem kontakter til tekstfil
    public static void SaveContacts()
    {
        // konverter hver kontakt til en linje i tekstfilen 
        var lines = contacts.Select(c => $"{c.Name},{c.PhoneNumber},{c.Email}");
        File.WriteAllLines(filePath, lines); // gem alle linjer til filen 
    }

    // Tilføj en ny kontakt
    public static void AddContact()
    {
        Console.Clear();
        Console.WriteLine("Tilføj ny kontakt:");

        // input for navn 
        Console.Write("Indtast navn: ");
        string name = Console.ReadLine();
        // input for telefonnummer
        Console.Write("Indtast telefonnummer: ");
        string phoneNumber = Console.ReadLine();
        // input for email
        Console.Write("Indtast e-mail: ");
        string email = Console.ReadLine();

        // valider telefonnummer og email, før de tilføjes 
        if (ValidatePhoneNumber(phoneNumber) && ValidateEmail(email))
        {
            contacts.Add(new Contact(name, phoneNumber, email)); // tilføj den gyldige kontakt til listen 
            Console.WriteLine("Kontakt tilføjet.");
        }
        else
        {
            Console.WriteLine("Fejl i dataene. Telefonnummer eller e-mail er ugyldig."); // kan ikke tilføje kontakt da email eller tilefonnummer er ugyldig
        }
        Console.ReadKey();
    }

    // Søg efter en kontakt
    public static void SearchContact()
    {
        Console.Clear();
        Console.Write("Indtast navn på kontakt: ");
        string searchName = Console.ReadLine();

        // Filtrer kontakter, hvor navnet indeholder den søgte streng (case-insensitiv)
        var result = contacts.Where(c => c.Name.Contains(searchName, StringComparison.OrdinalIgnoreCase)).ToList();

        // Vis resultater eller en besked, hvis ingen kontakter blev fundet
        if (result.Any())
        {
            Console.WriteLine("Fundne kontakter:");
            foreach (var contact in result)
            {
                Console.WriteLine($"{contact.Name} - {contact.PhoneNumber} - {contact.Email}");
            }
        }
        else
        {
            Console.WriteLine("Ingen kontakter fundet.");
        }
        Console.ReadKey();
    }

    // Rediger en kontakt
    public static void EditContact()
    {
        Console.Clear();
        Console.Write("Indtast navnet på kontakten du vil redigere: ");
        string searchName = Console.ReadLine();

        // find kontakt ved navn 
        var contact = contacts.FirstOrDefault(c => c.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

        if (contact != null)
        {
            Console.WriteLine("Rediger kontakt:");
            Console.Write($"Navn (nu: {contact.Name}): ");
            string newName = Console.ReadLine();
            Console.Write($"Telefonnummer (nu: {contact.PhoneNumber}): ");
            string newPhone = Console.ReadLine();
            Console.Write($"E-mail (nu: {contact.Email}): ");
            string newEmail = Console.ReadLine();
            
            // opretter kontaktens oplysninger 
            contact.Name = newName;
            contact.PhoneNumber = newPhone;
            contact.Email = newEmail;

            Console.WriteLine("Kontakt opdateret.");
        }
        else
        {
            Console.WriteLine("Kontakt ikke fundet.");
        }
        Console.ReadKey();
    }

    // Slet en kontakt
    public static void DeleteContact()
    {
        Console.Clear();
        Console.Write("Indtast navnet på kontakten du vil slette: ");
        string searchName = Console.ReadLine();

        // find og fjern kontakten 
        var contact = contacts.FirstOrDefault(c => c.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

        if (contact != null)
        {
            contacts.Remove(contact);
            Console.WriteLine("Kontakt slettet."); // fjern kontakten fra listen 
        }
        else
        {
            Console.WriteLine("Kontakt ikke fundet.");
        }
        Console.ReadKey();
    }

    // Vis kontakter med pagination (10 per side)
    public static void DisplayContacts()
    {
        Console.Clear();
        int pageSize = 10;
        int pageCount = (int)Math.Ceiling(contacts.Count / (double)pageSize);
        int currentPage = 1;

        while (true)
        {
            Console.Clear();
            var paginatedContacts = contacts.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            Console.WriteLine($"Side {currentPage}/{pageCount}:");

            // vis kontakterne for den aktuelle side 
            foreach (var contact in paginatedContacts)
            {
                Console.WriteLine($"{contact.Name} - {contact.PhoneNumber} - {contact.Email}");
            }

            // navigations muligheder 
            Console.WriteLine("\n1. Næste side  2. Forrige side  3. Tilbage");
            string choice = Console.ReadLine();

            // naviger mellem sider eller afslut 
            if (choice == "1" && currentPage < pageCount)
                currentPage++;
            else if (choice == "2" && currentPage > 1)
                currentPage--;
            else if (choice == "3")
                break;
        }
    }

    // Sorter kontakter alfabetisk
    public static void SortContacts()
    {
        contacts = contacts.OrderBy(c => c.Name).ToList(); // sorter efter navn
        Console.WriteLine("Kontakter sorteret.");
        Console.ReadKey();
    }

    // Valider telefonnummer (kun cifre)
    public static bool ValidatePhoneNumber(string phoneNumber)
    {
        return phoneNumber.All(char.IsDigit);
    }

    // Valider e-mail (skal indholde '@' og '.')
    public static bool ValidateEmail(string email)
    {
        return email.Contains('@') && email.Contains('.');
    }
}

