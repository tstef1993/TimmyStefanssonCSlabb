﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetName("Kalle");

            Console.WriteLine(person.GetName());

        }
    }
}
