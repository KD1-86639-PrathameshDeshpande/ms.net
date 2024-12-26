using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2
{
    
        
    internal class Program
    {
        static void Main(string[] args)
        {

            int add(int x, int y)
            {
                return x + y;
            }

            int sub(int x, int y)
            {
                return x - y;
            }

            int mul(int x, int y)
            {
                return x * y;
            }
            int div(int x, int y)
            {
                return x / y;
            }

            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.WriteLine("Enter your choice");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Calculator");
            Console.WriteLine("Enter first Number");
           int a= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
           int b= Convert.ToInt32(Console.ReadLine());

           




           

            switch (c)
            {
                case 1: Console.WriteLine(add(Convert.ToInt32(a), Convert.ToInt32(b)));
                    break;
                case 2:
                    Console.WriteLine(sub(Convert.ToInt32(a), Convert.ToInt32(b)));
                    break;
                case 3:
                    Console.WriteLine(mul(Convert.ToInt32(a), Convert.ToInt32(b)));
                    break;
                case 4:
                    Console.WriteLine(div(Convert.ToInt32(a), Convert.ToInt32(b)));
                    break;

            }

           
        }
    }
}
