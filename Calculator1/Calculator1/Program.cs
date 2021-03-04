using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            string Symbol;

            Console.WriteLine("请输入第一个数：");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数：");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("请从'+','-','*','/'运算符中选择一个输入：");
            Symbol = Console.ReadLine();

            switch (Symbol)
            {
                case "+":result = num1 + num2;
                    Console.WriteLine("结果是{0}", result);
                    break;
                case "-":result = num1 - num2;
                    Console.WriteLine("结果是{0}", result);
                    break;
                case "*":result = num1 * num2;
                    Console.WriteLine("结果是{0}", result);
                    break;
                case "/":result = num1 / num2;
                    Console.WriteLine("结果是{0}", result);
                    break;
                default: Console.WriteLine("请输入有效的运算符");
                    break;
            }

            
            Console.ReadKey();
        }
    }
}
