using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入数1:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("输入数2:");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("输入运算符:");
            switch (Console.ReadLine())
            {
                case "+": Console.WriteLine("结果：" + (n1 + n2));break;
                case "-": Console.WriteLine("结果：" + (n1 - n2)); break;
                case "*": Console.WriteLine("结果：" + n1 * n2); break;
                case "/":
                    if (n2 != 0)
                        Console.WriteLine("结果：" + n1 / n2);
                    else
                        Console.WriteLine("除数不可为0");
                    break;
            }
        }
    }
}
