using System;

namespace CS5_06
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {


                Console.Clear();
                Console.WriteLine("Введите любое количество целых положительных чисел");
                Console.WriteLine("Для завершения ввода нажмите любую не числовую клавишу");

                int[] numbers = new int[] { };

                do
                {
                    //TODO проверка на корректность ввода
                    string num = Console.ReadLine();
                    int check = 0;
                    if (Int32.TryParse(num, out check) == false)
                    {
                        break;
                    }
                    numbers = ResizeArray(numbers, Convert.ToInt32(num));
                    
                }
                while (true);

                Console.WriteLine(new string('-', 50));
                Console.WriteLine($"Средне арифметическое - {Calculate(numbers)}");
                Console.WriteLine("Продолжить? (да/нет)");

                if (Console.ReadLine() != "да") break;
            }
            while (true);
        }

        public static int Calculate(int[] integerNumbers)
        {
            int result = 0;
            
            for(int i = 0; i < integerNumbers.Length; i++)
            {
                result += integerNumbers[i];
            }

            result /= integerNumbers.Length;

            return result;
        }

        public static int[] ResizeArray(int[] oldArray, int newElement)
        {
            int newLength = oldArray.Length + 1;
            int[] newArray = new int[newLength];

            for(int i = 0; i < newLength; i++)
            {
                if( i == newLength - 1)
                {
                    newArray[i] = newElement;
                    break;
                }

                if(oldArray.Length > 0)
                newArray[i] = oldArray[i];
            }

            return newArray;
        }
    }
}
