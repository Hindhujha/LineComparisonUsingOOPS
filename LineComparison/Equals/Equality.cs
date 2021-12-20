using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison.Equals
{
    public class Equal
    {
        public int X1, X2, X3, X4, Y1, Y2, Y3, Y4;
        public void Equals()
        {
            Console.WriteLine("WELCOME TO LINE COMPARISON PROBLEM");
            
            Console.WriteLine("ENTER THE COORDINATES:");
            X1 = Convert.ToInt16(Console.ReadLine());
            X2 = Convert.ToInt16(Console.ReadLine());
            X3 = Convert.ToInt16(Console.ReadLine());
            X4 = Convert.ToInt16(Console.ReadLine());
            Y1 = Convert.ToInt16(Console.ReadLine());
            Y2 = Convert.ToInt16(Console.ReadLine());
            Y3 = Convert.ToInt16(Console.ReadLine());
            Y4 = Convert.ToInt16(Console.ReadLine());
        }

        public void calc()
        {
            var result1 = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
             double length1 = Math.Round((Double)result1, 2);
            Console.WriteLine("LENGTH OF THE LINE: " + length1);

            var result2 = Math.Sqrt(Math.Pow((X4 - X3), 2) + Math.Pow((Y4 - Y3), 2));
            double length2 = Math.Round((Double)result2, 2);
            Console.WriteLine("LENGTH OF THE LINE: " + length2);

            Console.WriteLine(length1.Equals(length2));
        }
            }
    }

