using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCollection
{
    class Sixth
    {
        public static List<Debtor> SixthExercise(List<Debtor> debtors)
        {
            double averageBorc = 0;
            double sum = 0;
            for (int i = 0; i < debtors.Count; i++)
            {
                sum = sum + debtors[i].Debt;
                

            }
            averageBorc = sum / debtors.Count;
            var result = debtors.Where<Debtor>(x => x.Debt > averageBorc);
            var finalResult = result.OrderBy(x => x.FullName.Substring(GetNthIndex(x.FullName,' ',2))).ToList();
            foreach (var item in finalResult)
            {
                Console.WriteLine(item.FullName+"                         "+item.Debt);
            }

            return finalResult;
        }
        public static List<Debtor> SixthExerciseSecond(List<Debtor> debtors)
        {
            double averageBorc = 0;
            double sum = 0;
            for (int i = 0; i < debtors.Count; i++)
            {
                sum = sum + debtors[i].Debt;


            }
            averageBorc = sum / debtors.Count;
            var result = debtors.Where<Debtor>(x => x.Debt > averageBorc);
            var finalResult = result.OrderByDescending(x =>x.Debt ).ToList();
            foreach (var item in finalResult)
            {
                Console.WriteLine(item.FullName + "                         " + item.Debt);
            }

            return finalResult;
        }
        static int GetNthIndex(string s, char t, int n)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t)
                {
                    count++;
                    if (count == n)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
