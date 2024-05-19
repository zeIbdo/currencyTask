
namespace currencyTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] currencies = { "USD", "EUR", "JPY", "TRY", "GBP" };
            decimal[] rates = { 1.7M, 1.8455M, 1.0911M, 0.0527M, 2.1513M };
            int idx = 0;
            int specificIdx = 0;
            bool ent = false;
            bool env = true;
            decimal conversionTotal = 0;
            decimal conversionAmount = 0;
            string specificCurrency;
            Console.WriteLine("Do you want to see all currencies and their rate for AZN?(if you want type \"show-recent-currency-rates\")");
            Console.WriteLine("Do you want to see specific currency and its rate for AZN?(if you want type \"find-currency-rate-by-code\")");
            Console.WriteLine("Do you want to convert your currency to AZN?(if you want type \"calculate-amount-by-currency\")");
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
                else if (answer == "find-currency-rate-by-code")
                {
                    Console.WriteLine("If you want to see specific currency rate type its alpha code");
                    specificCurrency = Console.ReadLine();
                    while (idx < currencies.Length)
                    {
                        if (currencies[idx] == specificCurrency)
                        {
                            ent = true;
                            specificIdx = idx;
                            break;
                        }
                        idx++;
                    }
                    if (ent == false)
                    {
                        Console.WriteLine("Your alpha code which you wrote wasnt found in database");
                    }
                    else
                        Console.WriteLine($"{currencies[specificIdx]}: {rates[specificIdx]}");
                    idx = 0;
                    Console.WriteLine("if you want to exit type \"exit\"");
                }
                else if (answer == "calculate-amount-by-currency")
                {
                    Console.WriteLine("Type amount and alpha code of your currency one by one: ");
                    Console.Write("Amount: ");
                    conversionAmount = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Alpha code: ");
                    specificCurrency = Console.ReadLine();
                    while (idx < currencies.Length)
                    {
                        if (currencies[idx] == specificCurrency)
                        {
                            ent = true;
                            specificIdx = idx;
                            conversionTotal = rates[specificIdx] * conversionAmount;
                            break;
                        }
                        idx++;
                    }
                    if (ent == false)
                        Console.WriteLine("Your alpha code which you wrote wasnt found in database");
                    else
                        Console.WriteLine($"{currencies[specificIdx]}: {conversionTotal}");
                    Console.WriteLine("if you want to exit type \"exit\"");
                    idx = 0;
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
