using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCollection
{
    class Twelve
    {
        public static List<Debtor> TwelveExercise(List<Debtor> debtors)
        {
            DateTime now = DateTime.Now;
            int range;

            for (int i = 0; i < debtors.Count; i++)
            {
                range = debtors[i].BirthDay.Month - now.Month;
                if (range < 0)
                {
                    range += 12;
                }
                if (500 * range >= debtors[i].Debt)
                {
                    Console.WriteLine(debtors[i].FullName+"  "+ debtors[i].Debt+"  "+debtors[i].BirthDay);
                }

            }
            
        
            

            return debtors;
        }
        
    }
}
