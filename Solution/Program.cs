using System;
using System.IO;
using Solution;


public class Vcard
{
    string? FirstName { get; set; }
    string? LastName { get; set; }
    int Telephone {  get; set; }
    string? Email { get; set; }

}
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        Console.WriteLine("Hello There");

        char answer = '?';
        while (answer != '6')
        {
            Console.WriteLine("\n\nChoose a option:\n");

            Console.WriteLine("1: Display all contatcs");
            Console.WriteLine("2: Add a new contacts");
            Console.WriteLine("3: Search for a contact by name");
            Console.WriteLine("4: Delete a conbtact");
            Console.WriteLine("5: Export a contact into a separate file");
            Console.WriteLine("6: End program\n");

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            answer = keyInfo.KeyChar;

            switch (answer)
            {
                default:
                    Console.WriteLine("\n\nInvalide option, try again!");
                    break;

                case '1':
                    DisplayAllCards();
                    break;

                case '2':
                    var input = new Input();

                    string firstName = Console.ReadLine();
                    string lastName = Console.ReadLine();
                    int tel = input.InputTel();
                    string email = Console.ReadLine();

                    string addUp = AddCards(firstName,lastName,tel,email);

                    //

                    break;

                case '3':

                    break;

                case '4':

                    break;

                case '5':

                    break;

                case '6':
                    Console.WriteLine("\nThx for using vCard manager 2000 ;)");
                    break;
            }


        }

    }

    public static void DisplayAllCards()
    {
        string line = "";
        try
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "contacts.vcf");
            StreamReader sr = new StreamReader(filePath);

            //line = sr.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            if (line == null)
            {
                Console.WriteLine("Press Enter to confirm");
            }
            sr.Close();
            Console.ReadLine();
        }
        catch (IOException e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Finish displaying");
        }

        
    }

    public static string AddCards(string firstName,string lastName, int tel, string email)
    {
        string vCard = $"BEGIN:VCARD\nFN:{firstName} {lastName}\nTEL:{tel}\nEMAIL:{email}\nEND:VCARD\n\n";

        return vCard;
    }

    public static void SearchCards()
    {

    }

    public static void DeleteCards()
    {

    }

    public static void ExportCards()
    {

    }

}

