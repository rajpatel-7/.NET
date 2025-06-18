using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class AreaCalculator
    {
        public double Area(double side)
        {
            return side * side;
        }
        
        public double Area(double length, double breadth)
        {
            return length * breadth;
        }
      
        public double Area(float radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
