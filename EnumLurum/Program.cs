using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumLurum
{
    class Program
    {

        enum EnumMenu
        {
            Ett, Tvau, Avsluta
        }

        static void Main(string[] args)
        {
            int counter = 0;
            foreach (var item in Enum.GetNames(typeof(EnumMenu)))
            {

                Console.WriteLine("{0}: {1}", counter++, item);
            }


        }
    }
}
