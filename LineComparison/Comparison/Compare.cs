using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison.Comparison
{
    internal class Compare
    {
        public int length1, length2;
        public void Comparison()
        {

            Equals.Equal equal = new Equals.Equal();
            equal.Equals();
            Console.WriteLine("LENGTH OF THE LINE: " + length1);

         
        Console.WriteLine("LENGTH OF THE LINE: " + length2);

            if (length1.CompareTo(length2) == 0)
            {
                Console.WriteLine("TWO LINES ARE EQUAL");
            }
            if (length1.CompareTo(length2) < 0)

            {
                Console.WriteLine("LESSER THAN LENGTH2");
            }

if (length1.CompareTo(length2) > 0)

{
    Console.WriteLine("GREATER THAN LENGTH2");
}

        }
    }
    }

