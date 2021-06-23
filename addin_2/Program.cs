using System;

namespace addin_2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Введите число");
                int number = Convert.ToInt32(Console.ReadLine());
                string isSimple = "простое ";
                string isPositive = number >= 0 ? "положительное " : "отрицательное ";

                for (int i = 2; i <= 9; i++)
                {
                    Console.WriteLine($"{number} % {i} = {number % i}");
                    if ((number % i == 0) && (Math.Abs(number) != i))
                    {
                        isSimple = "";
                        break;
                    }
                }

                Console.WriteLine(new string('-', 50));
                Console.WriteLine($"{number} - {isPositive}{isSimple}число");
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Продолжить? (да/нет)");
                if (Console.ReadLine() != "да") break;
            }
            while (true);
        }
            
    }
}
