using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_4
{
    class Circle
    {
        private double diameter;

        public void SetDiameter(double diameter)
        {
            this.diameter = diameter
        }

        public double GetDiameter()
        {
            return diameter;
        }

        public double GetCircumference()
        {
            return diameter * 3.1416;
        }

    }
}
