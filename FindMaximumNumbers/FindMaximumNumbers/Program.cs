using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumbers
{
      class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Max Number");

            int output = MaximumNumberCheck.maximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
        }
    }
}
