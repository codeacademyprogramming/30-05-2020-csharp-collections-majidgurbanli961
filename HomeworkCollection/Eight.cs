using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCollection
{
    class Eight
    {
        public static List<Debtor> EightExercise(List<Debtor> debtors)
        {
            var result = debtors.Where<Debtor>(x => CountOccurences(x.FullName) == true);
            var resultSecond = debtors.OrderBy(x => x.FullName).ToList();
            foreach (var item in resultSecond)
            {
                Console.WriteLine(item.FullName);

            }

            return resultSecond;
        }
        static bool CountOccurences(string fullName)
        {
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            for (int i = 0; i < fullName.Length; i++)
            {
               
                if (myDictionary.ContainsKey(fullName[i].ToString()))
                {
                    myDictionary[fullName[i].ToString()]++;

                }
                else
                {
                    myDictionary.Add(fullName[i].ToString(), 1);

                }
            }
            foreach (var item in myDictionary)
            {
                if (item.Value >= 3)
                {
                    return true;
                }

            }

            return false;
        }
    }
}
