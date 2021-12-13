using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison.Length
{
    internal class Length_2
    {
        public int X1, X2, Y1, Y2;
        public void Linelength()
        {
            Console.WriteLine("WELCOME TO LINE COMPARISON PROBLEM");
          
            Console.WriteLine("ENTER THE COORDINATES:");
            X1 = Convert.ToInt16(Console.ReadLine());
            X2 = Convert.ToInt16(Console.ReadLine());
            Y1 = Convert.ToInt16(Console.ReadLine());
            Y2 = Convert.ToInt16(Console.ReadLine());
            
        }

        public void answer()
        {
            var result = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            Double length = Math.Round((Double)result, 2);
            Console.WriteLine("LENGTH OF THE LINE: " + length);
        }
        }

    }

