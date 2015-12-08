using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.SetX(15);
            point.SetY(25);

            Console.WriteLine("X:" + point.GetX() + " " + "Y:" + point.GetY());
            Console.ReadLine();
            
            
        }
    }
}
