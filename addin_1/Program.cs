using System;

namespace addin_1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Задайте первое число:");
                int firstOperand = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Укажите действие:");
                string act = Console.ReadLine();
                Console.WriteLine("Задайте второе число:");
                int secondOperand = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(new string('-', 60));
                ShowResult(act, firstOperand, secondOperand);

                Console.WriteLine(new string('-', 60));
                Console.WriteLine("Повторим? (да/нет)");
                if (Console.ReadLine() != "да") break;
            }
            while (true);
        }

        public static int Add(int firstOperand, int secondOperand)
        {
            return firstOperand + secondOperand;
        }

        public static int Sub(int firstOperand, int secondOperand)
        {
            return firstOperand - secondOperand;
        }

        public static int Mul(int firstOperand, int secondOperand)
        {
            return firstOperand * secondOperand;
        }

        //TODO проверка деления на ноль
        public static int Div(int firstOperand, int secondOperand)
        {
            return firstOperand / secondOperand;
        }

        public static void ShowResult(string act, int firstOperand, int secondOperand)
        {
            switch (act)
            {
                case "+":
                    {
                        Console.WriteLine(Add(firstOperand, secondOperand));
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine(Sub(firstOperand, secondOperand));
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine(Mul(firstOperand, secondOperand));
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine(Div(firstOperand, secondOperand));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Операция задана неверно. Повторить? (да/нет)");
                        bool doItAgain = Console.ReadLine() == "да" ? true : false;
                        if (!doItAgain) break;
                        Console.WriteLine("Задайте корректную операцию:");
                        act = Console.ReadLine();
                        ShowResult(act, firstOperand, secondOperand);
                        break;
                    }
            }
        }
    }
}
