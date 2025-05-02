using System;
using System.IO;


public class Vcard
{
    string firstName = "first name";
    string lastName = "last name";

}
public class Program
{
    static void Main(string[] args)
    {
        
    }

    public static void DisplayAllCards()
    {
        string line;
        try
        {
            StreamReader sr = new StreamReader("contacts.vcf");
            line = sr.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("program Stop");
        }

        
    }

    public static void SearchCards()
    {

    }

    public static string AddCards(string firstName,string lastName, int tel, string email)
    {
        string vCard = $"BEGIN:VCARD\nFN:{firstName} {lastName}\nTEL:{tel}\nEMAIL:{email}\nEND:VCARD\n\n";

        return vCard;
    }

    public static void DeleteCards()
    {

    }

    public static void ExportCards()
    {

    }

}

