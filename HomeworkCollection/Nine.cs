using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCollection
{
    class Nine
    {
        public static int HansiIl(List<Debtor> debtors)
        {

            Dictionary<int, double> mydict = new Dictionary<int, double>();
            for (int i = 0; i < debtors.Count; i++)
            {
                if (mydict.ContainsKey(debtors[i].BirthDay.Year))
                {
                    mydict[debtors[i].BirthDay.Year] += debtors[i].Debt;
                }
                else
                {
                    mydict.Add(debtors[i].BirthDay.Year, debtors[i].Debt);

                }

            }
            double maxBorc = mydict.Values.Max();
            foreach (var item in mydict)
            {
                if (item.Value == maxBorc)
                {
                    Console.WriteLine("Maksimum borc" + item.Key + "bu il dogulanlardadi");
                    return item.Key;
                }

            }

            return 1;
        }

    }
}
