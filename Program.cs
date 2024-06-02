using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ex_04Calculator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            do
            {

                Console.WriteLine("-----------------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("-----------------------------");

                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("Enter Your first Number : ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Your Second Number : ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option : ");
                Console.WriteLine("\t + : ADD");
                Console.WriteLine(" \t- : SUBSTRACT");
                Console.WriteLine(" \t* : MULTIPLY");
                Console.WriteLine(" \t/ : DIVISION");

                Console.Write("Enter an option : ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your Result : {num1} + {num2} = " + result);
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your Result : {num1} - {num2}= " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your Result : {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your Result : {num1} / {num2} = " + result);
                        break;

                    default:
                        Console.WriteLine("That is not a valid option");
                        break;

                }

                Console.WriteLine("DO you want to continue? (Y = Yes, N = NO) : ");

            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Bye!");

            Console.ReadKey();
           
        }
    }
}
