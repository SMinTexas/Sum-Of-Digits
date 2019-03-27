using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Digits
{
    class DigitSum
    {
        public int sum(int num)
        {
            if (num != 0)
            {
                return (num % 10 + sum(num / 10));
            }
            else
            {
                return 0;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            int num, result;
            DigitSum ds = new DigitSum();
            Console.WriteLine("Enter the Number : ");
            num = int.Parse(Console.ReadLine());
            result = ds.sum(num);
            Console.WriteLine("Sum of Digits in {0} is {1}", num, result);
            Console.Read();
        }
    }
}
