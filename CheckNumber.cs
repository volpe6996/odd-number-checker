using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumberChecker
{
    public class CheckNumber
    {
        public bool EvenOrOdd(int num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
