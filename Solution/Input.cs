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
            Regex regexTel = new Regex(@"^\+\d{1,3}\s\d{2,4}/\d{2}\.\d{2}\.\d{2}$");

            while (true)
            {
                Console.WriteLine("\nInput the telephone number with the european format :");
                Console.WriteLine("+## ###/##.##.## OU +### ###/##.##.##");

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
