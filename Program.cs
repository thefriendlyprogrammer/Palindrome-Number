using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrom_Number");
            int n, temp, sum = 0, rev;
            Console.WriteLine("Enter the number : ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                rev = n % 10;
                sum = (sum * 10) + rev;
                n = n / 10;
            }
            if(temp == sum)
            {
                Console.WriteLine("Number is Palindrom");
            }
            else
            {
                Console.WriteLine("Number is not Palindrom");
            }
            Console.ReadLine();
        }
    }
}
