using System;

namespace addin_3
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                //Console.WriteLine("Set origin currency (U - ₴ , D - $ , R - ₽ , E - €)");
                Console.WriteLine("Set origin currency (U - uah , D - $ , R - rub , E - eur)");
                string originCurrency = SetCurrency(Convert.ToChar(Console.ReadLine()));
                Console.WriteLine($"Set value in {originCurrency}");
                //TODO сделать проверку на корректность ввода
                decimal originValue = Convert.ToDecimal(Console.ReadLine());
                //Console.WriteLine("Set exchange currency (U - ₴ , D - $ , R - ₽ , E - €)");
                Console.WriteLine("Set exchange currency (U - uah , D - $ , R - rub , E - eur)");
                string exchangeCurrency = SetCurrency(Convert.ToChar(Console.ReadLine()));
                decimal exchangedValue = GetExchangeValue(originCurrency, exchangeCurrency, originValue);
                Console.WriteLine(new string('-', 50));
                Console.WriteLine($"{originValue}{originCurrency} = {exchangedValue.ToString("0.00")}{exchangeCurrency}");
                Console.WriteLine(new string('-', 50));

                Console.WriteLine("Next operation? (y/n)");
                if (Console.ReadLine() != "y") break;
            }
            while (true);
        }

        public static string SetCurrency(char symbol)
        {
            switch (symbol)
            {
                case 'U':
                case 'u':
                    return "uah";
                case 'D':
                case 'd':
                    return "$";
                case 'R':
                case 'r':
                    return "rub";
                case 'E':
                case 'e':
                    return "eur";
                default:
                    Console.WriteLine("Set correct currency");
                    symbol = Convert.ToChar(Console.ReadLine());
                    return SetCurrency(symbol);
            }
        }

        public static decimal GetExchangeValue(string origin, string exchange, decimal value)
        {
            decimal result = 0.0m;
            string currentCase = origin + exchange;

            string[] cases = 
                { "uah$", "uahrub", "uaheur", "$uah", "$rub", "$eur", "rubuah", "rub$", "rubeur", "euruah", "eur$", "eurrub" };
            decimal[] ratio =
                {26.93m, 0.37m, 32.62m, 0.037m, 0.014m, 1.21m, 2.67m, 71.91m, 87.19m, 0.031m, 0.82m, 0.11m};

            int rationIndex = (Array.IndexOf(cases, currentCase));

            result = value / ratio[rationIndex];

            return result;
        }
    }

 
}
