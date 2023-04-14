using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefOut
{
    public class Calculator
    {
        public static void Triple (ref int x)
        {
            x *= 3;
        }

        public static void Triple2 (int origin, out int result)
        {
            result = origin * 3;
        }
    }
}