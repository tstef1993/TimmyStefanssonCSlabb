using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.SetDiameter (15);

            Circle circle2 = new Circle();
            circle2.SetDiameter(22);


            Console.WriteLine(circle.GetDiameter());
            Console.WriteLine(circle.GetCircumference());
            Console.ReadLine();
            
        }
    }
}
