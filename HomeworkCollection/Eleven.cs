using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCollection
{
    class Eleven
    {
        public static List<Debtor> ElevenFunction(List<Debtor> debtors)
        {

            var result = debtors.Where<Debtor>(x => NumberChecker(x)==true).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.FullName+"       "+item.Phone);

            }

            return debtors;
        }
        static bool NumberChecker(Debtor debtors)
        {
            Dictionary<string, int> myDict = new Dictionary<string, int>();
            for (int i = 0; i < debtors.Phone.Length; i++)
            {
                if (debtors.Phone[i] == '-')
                {
                    continue;
                }
                if (myDict.ContainsKey(debtors.Phone[i].ToString()))
                {
                    myDict[debtors.Phone[i].ToString()]++;

                }
                else
                {
                    myDict.Add(debtors.Phone[i].ToString(), 1);

                }

            }
           
            foreach (var item in myDict)
            {
                if (item.Value > 1)
                {
                    return false;
                }
               

            }
           

            return false;
        }

    }
}
