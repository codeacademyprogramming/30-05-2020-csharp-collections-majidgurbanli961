using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCollection
{
    class Fifth
    {
        public static List<Debtor> FifthExercise(List<Debtor> debtors)
        {
            var result=debtors.Where<Debtor>(x=> x.BirthDay.Month==12 || x.BirthDay.Month == 1 || x.BirthDay.Month == 2).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.FullName+ "              "+ item.BirthDay);

            }

            return result;
        }


    }
}
