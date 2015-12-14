using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StruktOperatorOverlagring
{
    class Program
    {
        static void Main(string[] args)
        {
            Cycle cycle = new Cycle(3,21);
            Cycle cycle2 = new Cycle(11, 17);

            cycle2 += -5;
            Console.WriteLine(cycle2);
            Console.ReadLine();
        }
    }
}
