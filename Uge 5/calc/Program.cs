using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Calculator calc = new Calculator();
                double left;
                double right;
                string option = "";
                double.TryParse(Console.ReadLine(), out left);
                option = Console.ReadLine();
                double result;

                switch (option)
                {
                    case "+":
                    {
                        double.TryParse(Console.ReadLine(), out right);
                        result = calc.Add(left, right);
                        Console.WriteLine(result);
                        break;
                    }
                    case "-":
                    {
                        double.TryParse(Console.ReadLine(), out right);
                        result = calc.Subtract(left, right);
                        Console.WriteLine(result);
                        break;
                    }
                    case "p":
                    {
                        double.TryParse(Console.ReadLine(), out right); 
                        result = calc.Power(left, right);
                        Console.WriteLine(result);
                            break;
                    }
                    case "*":
                    {
                        double.TryParse(Console.ReadLine(), out right);
                        result = calc.Multiply(left, right);
                        Console.WriteLine(result);
                            break;
                    }
                    default:
                    {
                        break;
                    }
                }
            }
        }

    }
}
