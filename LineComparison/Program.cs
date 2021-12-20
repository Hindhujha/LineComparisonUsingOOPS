using System;
namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO LINE COMPARISON PROBLEM");
            while (true)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("1.LENGTH OF A LINE");
                Console.WriteLine("2.TWO LINES ARE EQUAL OR NOT");
                Console.WriteLine("3.CHECKING LINES ARE GREATER/LESSER/EQUAL");
                Console.WriteLine("ENTER YOUR OPTION");

                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Length.Length_2 myObj = new Length.Length_2();
                        myObj.Linelength();
                        myObj.answer();
                        break;
                    case 2:
                        Equals.Equal equal= new Equals.Equal();
                        equal.Equals();
                        equal.calc();
                        break;
                    case 3:
                        Comparison.Compare comp=new Comparison.Compare();
                        comp.Comparison();  
                        break;
                    default:
                        Console.WriteLine("ENTER A CORRECT OPTION");
                        break;

                }
            }
        }
    }
}