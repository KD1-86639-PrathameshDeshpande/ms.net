using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
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
            while (true)
            {

                Console.WriteLine("Calculator");
                Console.WriteLine("**************");
                Console.WriteLine("1.Addition\n2.Subtract\n3.Multiply\n4.Divide\n5.Exit");
              
                Console.WriteLine("Enter your choice");
                int c = Convert.ToInt32(Console.ReadLine());


                switch (c)
                {
                    case 1:
                        Console.WriteLine("Enter first Number");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second Number");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(add(Convert.ToInt32(a), Convert.ToInt32(b)));
                        break;
                    case 2:
                        Console.WriteLine("Enter first Number");
                        int p= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second Number");
                        int q = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(sub(Convert.ToInt32(p), Convert.ToInt32(q)));
                        break;
                    case 3:
                        Console.WriteLine("Enter first Number");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second Number");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(mul(Convert.ToInt32(x), Convert.ToInt32(y)));
                        break;
                    case 4:
                        Console.WriteLine("Enter first Number");
                        int l = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second Number");
                        int m = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(div(Convert.ToInt32(l), Convert.ToInt32(m)));
                        break;
                    case 5:return;
                    default:Console.WriteLine("Invalid Input");
                        break;

                }
            }


        }
    }
}
