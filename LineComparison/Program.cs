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
                Console.WriteLine("ENTER YOUR OPTION");

                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Length.Length_2 myObj = new Length.Length_2();
                        myObj.Linelength();
                        myObj.answer();
                        break;
                    default:
                        Console.WriteLine("ENTER A CORRECT OPTION");
                        break;

                }
            }
        }
    }
}