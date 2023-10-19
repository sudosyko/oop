using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Uebungstest
{
    internal class ConsolePlus
    {

        public static int WriteRead(string inputFrageAlter)
        {

            Console.WriteLine(inputFrageAlter);
            return int.Parse(Console.ReadLine());
        }

        public static void WriteUnderline(string output)
        {
            Console.WriteLine(output);
            Console.WriteLine(new string('-', output.Length));
        }

        
    }
}
