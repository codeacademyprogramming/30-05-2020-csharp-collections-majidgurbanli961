using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCollection
{
    class Seven
    {
        public static List<Debtor> SevenExercise(List<Debtor> debtors)
        {
            var result = debtors.Where<Debtor>(x => x.Phone.IndexOf('8') == -1).ToList();
            DateTime now = DateTime.Now;
            double sum = 0;
           

            foreach (var item in result)
            {
                TimeSpan age = now - item.BirthDay;
                Console.WriteLine(item.Phone+"   " +(int)(age.TotalDays/365)+"  " + item.FullName.Substring(GetNthIndex(item.FullName,' ',2)));
                sum += item.Debt;
            }
            Console.WriteLine("Total sum is"+sum);
            return result;
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
