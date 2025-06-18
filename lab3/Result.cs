using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    interface Calculate1
    {
        int Addition(int a, int b);
        int Subtraction(int a, int b);
    }

    class Result : Calculate1
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
    }
}
