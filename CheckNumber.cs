using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumberChecker
{
    public class CheckNumber
    {
        public void IsOddNumber(int num)
        {
            if (num %2 == 0)
                Console.WriteLine("Liczba dodatnia");
            else
                Console.WriteLine("Liczba ujemna");
        }
    }
}
