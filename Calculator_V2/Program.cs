using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Calc = true;
            {
                while (Calc)
                {

                    Console.WriteLine(" \t\t\t\t Calculator ");

                    Console.Write("Enter the first number: ");
                    decimal x = decimal.Parse(Console.ReadLine());

                    Console.Write("Enter the second number:");
                    decimal y = decimal.Parse(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine("1: Addition");
                    Console.WriteLine("2: Subtraction");
                    Console.WriteLine("3: Multiplication");
                    Console.WriteLine("4: Division\n");


                    Console.WriteLine("Enter your operation \n");
                    int operation = int.Parse(Console.ReadLine());

                    switch (operation)
                    {
                        case 1:
                            var sum = x + y;
                            Console.WriteLine("Result is: {0}\n", sum);
                            break;

                        case 2:
                            var sub = x - y;
                            Console.WriteLine("Result is: \n{0}", sub);
                            break;

                        case 3:
                            var mul = x * y;
                            Console.WriteLine("Result is: {0}\n", mul);
                            break;

                        case 4:
                            if (y == 0)
                            {
                                Console.WriteLine("Can't divide by 0");
                                break;
                            }
                            else
                            {
                                var div = x / y;
                                Console.WriteLine("Result is: {0}\n", div);
                            }
                            break;

                        default:
                            Console.Write("Invalid Input \n");
                            break;
                    }
                    Console.WriteLine("Continue to Calculator? : (y/n)");
                    string option = Console.ReadLine();
                    option = option.ToLower();
                    if (option == "y")
                    {
                        Calc = true;
                    }
                    else
                    {

                        Console.WriteLine("Thank you ! Have a Good day ");
                        Calc = false;
                    }
                }

                Console.ReadLine();
            }


        }
    }
}
