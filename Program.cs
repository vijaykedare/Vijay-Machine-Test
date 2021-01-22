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

            
            if (n % 2 == 0)
                return false;

            
            for (int i = 3; i <= Math.Sqrt(n); i = i + 2)
            {
               
                if (n % i == 0)
                {
                    n = n / i;

                   
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
