using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class OpgaveC1

{
    static List<Contact> contacts = new List<Contact>();
    static string filePath = "contacts.txt";

    public static void Kør()
    {
        LoadContacts();
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

            switch (choice)
            {
                case "1":
                    AddContact();
                    break;
                case "2":
                    SearchContact();
                    break;
                case "3":
                    EditContact();
                    break;
                case "4":
                    DeleteContact();
                    break;
                case "5":
                    DisplayContacts();
                    break;
                case "6":
                    SortContacts();
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg, prøv igen.");
                    break;
            }
        }
        SaveContacts();
    }

    // Kontaktklasse
    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

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
                var parts = line.Split(',');
                if (parts.Length == 3)
                {
                    contacts.Add(new Contact(parts[0], parts[1], parts[2]));
                }
            }
        }
    }

    // Gem kontakter til tekstfil
    public static void SaveContacts()
    {
        var lines = contacts.Select(c => $"{c.Name},{c.PhoneNumber},{c.Email}");
        File.WriteAllLines(filePath, lines);
    }

    // Tilføj en ny kontakt
    public static void AddContact()
    {
        Console.Clear();
        Console.WriteLine("Tilføj ny kontakt:");

        Console.Write("Indtast navn: ");
        string name = Console.ReadLine();
        Console.Write("Indtast telefonnummer: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Indtast e-mail: ");
        string email = Console.ReadLine();

        if (ValidatePhoneNumber(phoneNumber) && ValidateEmail(email))
        {
            contacts.Add(new Contact(name, phoneNumber, email));
            Console.WriteLine("Kontakt tilføjet.");
        }
        else
        {
            Console.WriteLine("Fejl i dataene. Telefonnummer eller e-mail er ugyldig.");
        }
        Console.ReadKey();
    }

    // Søg efter en kontakt
    public static void SearchContact()
    {
        Console.Clear();
        Console.Write("Indtast navn på kontakt: ");
        string searchName = Console.ReadLine();

        var result = contacts.Where(c => c.Name.Contains(searchName, StringComparison.OrdinalIgnoreCase)).ToList();

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

        var contact = contacts.FirstOrDefault(c => c.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

        if (contact != null)
        {
            contacts.Remove(contact);
            Console.WriteLine("Kontakt slettet.");
        }
        else
        {
            Console.WriteLine("Kontakt ikke fundet.");
        }
        Console.ReadKey();
    }

    // Vis kontakter med pagination
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

            foreach (var contact in paginatedContacts)
            {
                Console.WriteLine($"{contact.Name} - {contact.PhoneNumber} - {contact.Email}");
            }

            Console.WriteLine("\n1. Næste side  2. Forrige side  3. Tilbage");
            string choice = Console.ReadLine();

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
        contacts = contacts.OrderBy(c => c.Name).ToList();
        Console.WriteLine("Kontakter sorteret.");
        Console.ReadKey();
    }

    // Valider telefonnummer
    public static bool ValidatePhoneNumber(string phoneNumber)
    {
        return phoneNumber.All(char.IsDigit);
    }

    // Valider e-mail
    public static bool ValidateEmail(string email)
    {
        return email.Contains('@') && email.Contains('.');
    }
}

