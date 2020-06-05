using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCollection
{
    class Ten
    {
        public static List<Debtor> TenExercise(List<Debtor> debtor)
        {
            var result = debtor.OrderBy(x => x.Debt).ToList();
            List<Debtor> secondResult = new List<Debtor>();
            for (int i = result.Count-6; i < result.Count; i++)
            {
                secondResult.Add(result[i]);

            }
            foreach (var item in secondResult)
            {
                Console.WriteLine(item.FullName+"        "+ item.Debt);
            }

            return secondResult;
        }
    }
}
