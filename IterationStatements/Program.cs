using System.ComponentModel;
using System.Reflection.Metadata;

namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintRange(1000, -1000);
            MultiTable();
        }

        // Write a method to accept two integers as
        // parameterss and check whether they are equal or not
        public static bool IsEqual(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            
            return false;
        }


        //Write a method that will print to the console numbers
        //3 through 999 by 3 each time
        public static void Threes()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }




        //Write a method that will print to the console
        //all numbers 1000 through -1000
        public static void PrintRange(int ceiling, int floor)
        {
            for (int i = ceiling; i >= floor; i--)
            {
                Console.WriteLine(i);
            }
        
        }

        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"That's even");
            }
            else
            {
                Console.WriteLine($"That's odd");
            }

        }

        // Write a method to check whether
        // a given number is positive or negative.
        public static bool IsPositive(int num1)
        {
            if (num1 > 0)
            {
                return true;
            }

            return false;

        }

        // Write a method to read the age of a candidate
        // and determine whether they can vote.

        public static bool OfVotingAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"Yes they are of voting age");
                return true;
            }
            else
            {
                Console.WriteLine($"Too young to vote by {18 - age} years");
                return false;
            }
        
        }

        //Write a method to check if an integer
        //(from the user) is in the range -10 to 10
        public static bool IsTenRange(int num)
        {
            if (num <= 10 && num >= -10)
            {
                return true;
            }

            return false;
        }

        //Write a method to display the multiplication table
        //(from 1 to 12) of a given integer
        public static void MultiTable()
        {
            int n, i, range;
            Console.WriteLine("Enter Any integer: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Range: ");
            range = int.Parse(Console.ReadLine());

            for (i = 1; i <= range; i++)
            {
                Console.WriteLine("The Product of {0} and {1} = {2}", n, i, n * i );
            }
        }
    }
}
