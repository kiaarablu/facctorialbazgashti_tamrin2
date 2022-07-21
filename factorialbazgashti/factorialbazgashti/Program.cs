using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialbazgashti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("pleas enter your number...");
            UInt64 number = Convert.ToUInt64(Console.ReadLine());
            UInt64 print = factorial(number);
            Console.WriteLine(print);
            Console.ReadKey();
        }
        public static UInt64 factorial (UInt64 n )
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1 );
            }
            
            
            
        }
        
    }
}
