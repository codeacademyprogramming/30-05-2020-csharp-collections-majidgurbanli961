using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCollection
{
    class FourthClass
    {

        public static List<Debtor> Fourth(List<Debtor> debtors)
        {
          
            Console.WriteLine( );  
            var result = debtors.Where<Debtor>(x => x.FullName.Length > 16  && x.Phone.Count(f => f == '7')>=2).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.FullName+"    "+item.Phone);

            }

            return result;

        }
        
    }
}
