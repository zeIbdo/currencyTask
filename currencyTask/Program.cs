
namespace currencyTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] currencies = { "USD", "EUR", "JPY", "TRY", "GBP" };
            decimal[] rates = { 1.7M, 1.8455M, 1.0911M, 0.0527M, 2.1513M };
            int idx = 0;
            bool env = true;
            Console.WriteLine("Do you want to see all currencies and their rate for AZN?(if you want type \"show-recent-currency-rates\")");
            while (env == true)
            {
                string answer = Console.ReadLine();
                if (answer == "show-recent-currency-rates")
                {
                    while (idx < currencies.Length)
                    {
                        Console.WriteLine($"{currencies[idx]}: {rates[idx]}");
                        idx++;
                    }
                    idx = 0;
                    Console.WriteLine("if you want to exit type \"exit\"");
                }
                else if (answer == "exit")
                {
                    env = false;
                }
                else
                {
                    Console.Write("the command that you wrote was not found in system, ");
                    Console.WriteLine("if you want to exit type \"exit\"");

                }
            }
        }
    }
}
