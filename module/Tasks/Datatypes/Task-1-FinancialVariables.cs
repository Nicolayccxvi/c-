using System;

namespace FinancialVariablesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Int - Fibonacci number used in technical analysis (e.g., number of levels)
            int fibonacciLevel = 8;

            // Long - number of shares owned by JPMorgan Chase in a portfolio (hypothetical example)
            long jpMorganHoldings = 1500000000L;

            // Float - Alpha value representing an asset's performance relative to the market
            float alpha = 0.12f;

            // Decimal - Beta value representing an asset's volatility relative to the market
            decimal beta = 1.35m;

            // Double - Theta value representing the time decay of an option
            double theta = -0.05;

            // Decimal - Gamma value representing the rate of change in delta (sensitivity to price changes)
            decimal gamma = 0.25m;

            // String - Name of a major financial institution, e.g., JPMorgan Chase
            string bankName = "JPMorgan Chase";

            // Bool - To check if Fibonacci number is an indicator of an upward trend
            bool isFibonacciTrendPositive = true;

            // Output to verify the values
            Console.WriteLine($"Fibonacci Level (int): {fibonacciLevel}");
            Console.WriteLine($"JPMorgan Holdings (long): {jpMorganHoldings}");
            Console.WriteLine($"Alpha (float): {alpha}");
            Console.WriteLine($"Beta (decimal): {beta}");
            Console.WriteLine($"Theta (double): {theta}");
            Console.WriteLine($"Gamma (decimal): {gamma}");
            Console.WriteLine($"Bank Name (string): {bankName}");
            Console.WriteLine($"Is Fibonacci Trend Positive (bool): {isFibonacciTrendPositive}");
        }
    }
}
