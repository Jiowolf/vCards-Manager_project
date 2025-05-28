using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Solution
{
    public class Input
    {
        public string InputTel()
        {
            Regex regexTel = new Regex(@"^\+33\d{9}$");

            while (true)
            {
                Console.WriteLine("\nInput the telephone number with the French format :");
                Console.WriteLine("+33#########");

                string input = Console.ReadLine();

                if (regexTel.IsMatch(input))
                {

                    return input;
                }
                else
                {
                    Console.WriteLine("Format invalide\n");
                }
            }
        }
    }
}
