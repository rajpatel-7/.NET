using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class Sum
{
    // Abstract methods to be implemented in the derived class
    public abstract int SumOfTwo(int a, int b);
    public abstract int SumOfThree(int a, int b, int c);
}

class Calculate : Sum
{
    // Implementing the abstract methods
    public override int SumOfTwo(int a, int b)
    {
        return a + b;
    }

    public override int SumOfThree(int a, int b, int c)
    {
        return a + b + c;
    }
}
}
