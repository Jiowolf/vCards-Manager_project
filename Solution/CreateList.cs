using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class CreateList
    {
        public List<VCardsObj> VCardList(string vCard)
        {
            List<VCardsObj> vCardList = [];

            string[] vcards = vCard.Split("BEGIN:VCARD", StringSplitOptions.RemoveEmptyEntries);


            foreach (string vcard in vcards)
            {
                string[] lines = vCard.Split('\n', StringSplitOptions.RemoveEmptyEntries);
                var vcardObj = new VCardsObj();

                foreach (string line in lines)
                {
                    if (line.StartsWith("FN:"))
                    {
                        string fullName = line.Substring(3);
                        string[] firstLast = fullName.Split(' ');

                        vcardObj.FirstName = firstLast[0];
                        vcardObj.LastName = string.Join(" ", firstLast.Skip(1)); // si le nom de famille est composé, on as tout comme ça

                    }
                    else if (line.StartsWith("TEL:"))
                    {
                        vcardObj.Phone = line.Substring(4);
                    }
                    else if (line.StartsWith("EMAIL:"))
                    {
                        vcardObj.Email = line.Substring(6);

                    }
                }

                vCardList.Add(vcardObj);
            }        

            return vCardList;

        }
    }
}
