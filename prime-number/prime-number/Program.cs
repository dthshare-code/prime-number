using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please put your number to check isPrimeNumber here: ");
            int n = int.Parse(Console.ReadLine());
            if (is_prime_number(n))
                Console.WriteLine(n + " is prime number");
            else Console.WriteLine(n + " is not prime number");
            Console.ReadLine();
        }

        static bool is_prime_number(int n)
        {
            try
            {
                if (n <= 1)
                {
                    return false;
                }
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                        return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
