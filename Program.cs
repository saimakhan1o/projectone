using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWord
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BigInteger i = 18000000;
            Console.WriteLine(i.ToWords());

            
            i = 12233442;
            Console.WriteLine(i.ToWords());
            

            Console.ReadKey();
        }
    }
}


