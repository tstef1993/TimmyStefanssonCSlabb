using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_2
{
    public class Circle
    {
        private double diameter;
        public double GetDiameter()
        {
            return diameter;

        }
        public void SetDiameter(double diameter)
        {
            this.diameter = diameter;
        }

         public double GetCircumference()
        {
            return diameter * 3.1416;
        }    
    }
}
