using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFreeNumber
{
    class Program
    {
        static bool isSquareFree(int n)
        {
            if (n % 2 == 0)
                n = n / 2;

            // If 2 again divides n, then n is  
            // not a square free number. 
            if (n % 2 == 0)
                return false;

            // n must be odd at this point. So we can  
            // skip one element (Note i = i +2) 
            for (int i = 3; i <= Math.Sqrt(n); i = i + 2)
            {
                // Check if i is a prime factor 
                if (n % i == 0)
                {
                    n = n / i;

                    // If i again divides, then  
                    // n is not square free 
                    if (n % i == 0)
                        return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
           int n = 5; 
        if (isSquareFree(n)) 
        Console.WriteLine("Yes"); 
        else
            Console.WriteLine("No");
        Console.ReadLine();
        }
    }
}
