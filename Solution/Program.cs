using System;
using System.IO;
using Solution;



public class Program
{
    static void Main(string[] args)
    {
        string file = File.ReadAllText("contacts.vcf"); //read file et give string
        

        Console.WriteLine("");

        Console.WriteLine("Hello There");

        char answer = '?';
        while (answer != '6')
        {
            Console.WriteLine("\n\nChoose a option:\n");

            Console.WriteLine("1: Display all contatcs");
            Console.WriteLine("2: Add a new contacts");
            Console.WriteLine("3: Search for a contact by name");
            Console.WriteLine("4: Delete a contact");
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
                    DisplayAllCards(file);
                    break;

                case '2':
                    var input = new Input();
                    var addcard = new VCardsObj();

                    Console.Write("\nFirstname :");
                    addcard.FirstName = Console.ReadLine();
                    Console.Write("\nLastname :");
                    addcard.LastName = Console.ReadLine();
                    addcard.Phone = input.InputTel();
                    Console.Write("\nE-mail :");
                    addcard.Email = Console.ReadLine();

                    string addUp = AddCards(addcard);

                    //

                    break;

                case '3':
                    Console.WriteLine(SearchCards(file));
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

    public static void DisplayAllCards(string file)
    {
        //string line = "";
        //try
        //{
        //    string filePath = Path.Combine(AppContext.BaseDirectory, "contacts.vcf");
        //    StreamReader sr = new StreamReader(filePath);

        //    //line = sr.ReadLine();

        //    while (line != null)
        //    {
        //        Console.WriteLine(line);
        //        line = sr.ReadLine();
        //    }
        //    if (line == null)
        //    {
        //        Console.WriteLine("Press Enter to confirm");
        //    }
        //    sr.Close();
        //    Console.ReadLine();
        //}
        //catch (IOException e)
        //{
        //    Console.WriteLine("Exception: " + e.Message);
        //}
        //finally
        //{
        //    Console.WriteLine("Finish displaying");
        //}
        Console.WriteLine("\n\n");
        Console.WriteLine(file);
    }

    public static string AddCards(VCardsObj vcard)
    {
        string vCard = $"BEGIN:VCARD\nFN:{vcard.FirstName} {vcard.LastName}\nTEL:{vcard.Phone}\nEMAIL:{vcard.Email}\nEND:VCARD\n\n";

        return vCard;
    }

    public static string SearchCards(string vcard)
    {
        var toList = new CreateList();

        List<VCardsObj> list = toList.VCardList(vcard);

        list.Sort((a, b) => string.Compare(a.LastName, b.LastName, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("\n\nWrite the last name you searching ");
        string name = Console.ReadLine();

        var found = false;
        string person = "";

        foreach(VCardsObj obj in list)
        {
            if (obj.LastName == name)
            {
               found = true;
               person = $"\n\nFN:{obj.FirstName} {obj.LastName}\nTEL:{obj.Phone}\nEMAIL:{obj.Email}\n";
            }
            
        }
        if (found == false)
        {
            return "\n\nWe don't have that person or the name was wrong, Sorry";
        }
        else
        {
            return person;
        }
    }

    public static void DeleteCards(string vcard)
    {
        var toList = new CreateList();

        List<VCardsObj> list = toList.VCardList(vcard);


    }

    public static void ExportCards()
    {

    }

}

