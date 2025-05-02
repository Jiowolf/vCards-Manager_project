using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }

    public static string DisplayCards()
    {

    }

    public static void SearchCards()
    {

    }

    public static string AddCards(string firstName,string lastName, int tel, string email)
    {
        string vCard = $"BEGIN:VCARD\nFN:{firstName} {lastName}\nTEL:{tel}\nEMAIL:{email}\nEND:VCARD\n\n";
    }

    public static void DeleteCards()
    {

    }

    public static void ExportCards()
    {

    }

}

