using System;
using System.Collections.Generic;
using System.Linq;


namespace PadawansTask6
{
    public static class NumberFinder
    {
        public static int? NextBiggerThan(int number)
        {
            if (number >= int.MaxValue || number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if ( number == 0){
                return null;
            }
            else
            {
                string strNumber = number.ToString();
                char[] arrayNumber = strNumber.ToCharArray();
                List<int> list = new List<int>();
                foreach (var item in arrayNumber) list.Add(int.Parse(item.ToString()));
                int count = list.Count - 2;
                for (int i = list.Count - 1; i > 0; i--)
                {
                    if (list[i] > list[count])
                    {
                        int x = list[i];
                        list[i] = list[count];
                        list[count] = x;
                        break;
                    }

                }
                string readyNumber = "";
                foreach (var item in list) readyNumber += item;
                if (number == int.Parse(readyNumber))
                {
                    return null;
                }
                return int.Parse(readyNumber);

            }

        }
    }
}
