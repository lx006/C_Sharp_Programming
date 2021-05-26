using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShape
{
    abstract class Shape
    {
        protected double radius, length, breadth;

        public abstract void area();
        public abstract void perimeter(); 
    }
}
