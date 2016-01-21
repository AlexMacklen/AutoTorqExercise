using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTorqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public static class Palindrome
    {
        public static bool IsPalindrome(string str)
        {
            str = str.ToLower();
            int middle = str.Length / 2;

            if (str.Length % 2 == 1)
            {
                middle--;
            }

            for (int index = 0; index <= middle; index++)
            {
                if (str[index] != str[str.Length - 1 - index])
                    return false;
            }
            return true;
        }
    }

    // A less blank mind produces this.
    public static class Fibonacci
    {
        //More testable version
        //public static Func<Func<int,int,int,int>,int, int> GetFibNumber = (f,i) => f(0, 1, i);
        public static Func<int, int> GetFibNumber = i => Fib(0, 1, i);

        public static Func<int, int, int, int> Fib = (x, y, i) =>
        {
            if (i < 0) throw new InvalidDataException("No negative numbers");
            if (i <= 0) return x; 
            
            return Fib(y, x + y, --i);
        };
    }

    public class Perfect
    {
        public static int PerfectCheck(int n)
        {
            if (n<=0) throw new InvalidDataException("Zero or negative aren't valid numbers to check for perfectness.");

            var divisors = new List<int>();
            for (int index = 1; index < (n/2)+1; index++)
            {
                if (n%index == 0)
                {
                    divisors.Add(index);
                }
            }

            int sum = divisors.Sum();

            if (sum == n)
                return 0;

            if (sum < n)
                return -1;

            return 1;
        }
    }
}
