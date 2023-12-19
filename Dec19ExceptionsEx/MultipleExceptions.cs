using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec19ExceptionsEx
{
    internal class MultipleExceptions
    {
        public static double Calculators(double v1, double v2, char ch)
        {
            double result = 0.0;
            switch (ch)
            {
                case '+': { result = v1 + v2; break; }
                case '-': { result = v1 - v2; break; }
                case '*': { result = v1 * v2; break; }
                case '/': { result = v1 / v2; break; }

            }
            return result;//local
        }
        static void Main(string[] args)
        {
            double num1, num2;
            double Result = 0;
            char choice;
            try
            {
                Console.WriteLine("enter first number");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("please enter ur choice + or - or * or /");
                choice = char.Parse(Console.ReadLine());
                if (choice != '+' && choice != '-' && choice != '*' && choice != '/')
                    throw new Exception(choice.ToString());
                Console.WriteLine("enter second number");
                num2 = double.Parse(Console.ReadLine());
                if (choice == '/') if (num2 == 0) throw new DivideByZeroException("division by zero is not allowed");
                Result = Calculators(num1, num2, choice);
                Console.WriteLine("\n {0} \t {1} \t {2} \t = {3} ", num1, choice, num2, Result);
            }
            catch (FormatException fe) { Console.WriteLine("the numbers we typed is not valid"); Console.WriteLine(fe.Message); }
            catch(DivideByZeroException de) { Console.WriteLine(de.Message); }
            // executes when correct choice not entered 
            catch (Exception ex) { Console.WriteLine(" choice error {0} not a valid choice ",ex.Message); }
            Console.ReadLine();
            // to check debug enter proper values line by line execution we ssee
        }
    }
}
