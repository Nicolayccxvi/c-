using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to your favorite Console Banking App!");
            Thread.Sleep(1000);

            BankAccount account = new BankAccount();
            StockMarket market = new StockMarket();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- Bank_CCXVI ---");
                Console.WriteLine("1. Deposit Money");
                Console.WriteLine("2. Withdraw Money");
                Console.WriteLine("3. View Balance");
                Console.WriteLine("4. Speculate on Stocks/Commodities");
                Console.WriteLine("5. Exit Trade");
                Console.WriteLine("6. Watch Stock Market (Real-Time)");
                Console.WriteLine("7. View Portfolio Performance");
                Console.WriteLine("8. Exit App");
                Console.Write("\nChoose an option: ");
                string? choice = Console.ReadLine();
                if (choice == null) continue;

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Enter amount to deposit: ");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        {
                            account.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        PauseAndContinue();
                        break;

                    case "2":
                        Console.Clear();
                        Console.Write("Enter amount to withdraw: ");
                        if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                        {
                            account.Withdraw(withdrawAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        PauseAndContinue();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine($"Your current balance is: ${account.Balance:F2}");
                        PauseAndContinue();
                        break;

                    case "4":
                        Console.Clear();
                        market.Speculate(account);
                        PauseAndContinue();
                        break;

                    case "5":
                        Console.Clear();
                        market.ExitTrade(account);
                        PauseAndContinue();
                        break;

                    case "6":
                        Console.Clear();
                        market.WatchMarket();
                        break;

                    case "7":
                        Console.Clear();
                        market.ViewPortfolioPerformance();
                        PauseAndContinue();
                        break;

                    case "8":
                        Console.Clear();
                        Console.WriteLine("Goodbye!");
                        Thread.Sleep(1500);
                        Console.ResetColor();
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please choose a valid menu item.");
                        PauseAndContinue();
                        break;
                }
            }
        }

        static void PauseAndContinue()
        {
            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }
    }

    public class BankAccount
    {
        public double Balance { get; private set; }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Successfully deposited ${amount:F2}. New balance: ${Balance:F2}");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
                Thread.Sleep(1000);
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Successfully withdrew ${amount:F2}. New balance: ${Balance:F2}");
                Thread.Sleep(1000);
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
                Thread.Sleep(1000);
            }
        }
    }

    public class StockMarket
    {
        private Random _random = new Random();
        private Dictionary<string, double> _assets = new Dictionary<string, double>()
        {
            {"Tesla Stock", 200.0},
            {"Apple Stock", 150.0},
            {"Amazon Stock", 3500.0},
            {"NASDAQ Index", 14000.0},
            {"S&P 500", 4500.0},
            {"Gold", 1950.0},
            {"Silver", 24.0},
            {"Crude Oil (WTI)", 80.0},
            {"Natural Gas", 3.5},
            {"Bitcoin", 40000.0},
            {"Ethereum", 2500.0}
        };

        private Dictionary<string, double> _portfolio = new Dictionary<string, double>(); // Stores units owned
        private Dictionary<string, double> _investmentCost = new Dictionary<string, double>(); // Tracks original investments

        public void Speculate(BankAccount account)
        {
            Console.WriteLine("--- Speculate on Assets ---");
            foreach (var asset in _assets)
            {
                Console.WriteLine($"{asset.Key}: ${asset.Value:F2}");
            }

            Console.Write("\nEnter the name of the asset you want to speculate on: ");
            string? assetName = Console.ReadLine();

            if (assetName != null && _assets.ContainsKey(assetName))
            {
                Console.Write("Enter the amount you want to invest: ");
                if (double.TryParse(Console.ReadLine(), out double investment))
                {
                    if (investment > account.Balance)
                    {
                        Console.WriteLine("Insufficient funds.");
                        return;
                    }

                    double priceAtPurchase = _assets[assetName];
                    double units = investment / priceAtPurchase;

                    account.Withdraw(investment);
                    _portfolio[assetName] = _portfolio.ContainsKey(assetName) ? _portfolio[assetName] + units : units;
                    _investmentCost[assetName] = _investmentCost.ContainsKey(assetName) ? _investmentCost[assetName] + investment : investment;

                    Console.WriteLine($"You purchased {units:F4} units of {assetName} at ${priceAtPurchase:F2} per unit.");
                }
                else
                {
                    Console.WriteLine("Invalid investment amount.");
                }
            }
            else
            {
                Console.WriteLine("Invalid asset name.");
            }
        }

        public void WatchMarket()
        {
            Console.WriteLine("--- Watching Stock Market ---");
            Console.WriteLine("Press 'Q' to stop watching.\n");

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Q)
                    {
                        Console.WriteLine("\nExiting real-time market view...");
                        Thread.Sleep(1000);
                        return;
                    }
                }

                Console.Clear();
                Console.WriteLine("--- Real-Time Market Prices ---");

                foreach (var asset in _assets.Keys)
                {
                    double priceChange = _random.NextDouble() * 2 - 1; // Price change between -1% and +1%
                    _assets[asset] *= 1 + priceChange / 100;
                    Console.WriteLine($"{asset}: ${_assets[asset]:F2} (Change: {priceChange:F2}%)");
                }

                Console.WriteLine("\n--- Your Portfolio ---");
                if (_portfolio.Count == 0)
                {
                    Console.WriteLine("You have no active investments.");
                }
                else
                {
                    foreach (var trade in _portfolio)
                    {
                        string asset = trade.Key;
                        double unitsOwned = trade.Value;
                        double currentPrice = _assets[asset];
                        double currentValue = unitsOwned * currentPrice;
                        double originalInvestment = _investmentCost[asset];

                        Console.WriteLine($"{asset}: Units Owned: {unitsOwned:F4}, Original Investment: ${originalInvestment:F2}, Current Value: ${currentValue:F2}");
                    }
                }

                Thread.Sleep(10000); 
            }
        }

        public void ExitTrade(BankAccount account)
        {
            if (_portfolio.Count == 0)
            {
                Console.WriteLine("You have no active trades.");
                return;
            }

            Console.WriteLine("--- Active Trades ---");
            foreach (var trade in _portfolio)
            {
                Console.WriteLine($"{trade.Key}: Units Owned: {trade.Value:F4}");
            }

            Console.Write("\nEnter the name of the asset to exit trade: ");
            string? assetName = Console.ReadLine();

            if (assetName != null && _portfolio.ContainsKey(assetName))
            {
                double units = _portfolio[assetName];
                double currentPrice = _assets[assetName];
                double finalAmount = units * currentPrice;

                _portfolio.Remove(assetName);
                _investmentCost.Remove(assetName);

                account.Deposit(finalAmount);
                Console.WriteLine($"Exited trade on {assetName}. Sold {units:F4} units at ${currentPrice:F2} per unit. Total: ${finalAmount:F2}");
            }
            else
            {
                Console.WriteLine("Invalid asset name or trade not found.");
            }
        }

        public void ViewPortfolioPerformance()
        {
            double stocks = 0, commodities = 0, crypto = 0;

            foreach (var trade in _portfolio)
            {
                if (trade.Key.Contains("Stock") || trade.Key.Contains("Index"))
                    stocks += trade.Value * _assets[trade.Key];
                else if (trade.Key.Contains("Gold") || trade.Key.Contains("Oil"))
                    commodities += trade.Value * _assets[trade.Key];
                else
                    crypto += trade.Value * _assets[trade.Key];
            }

            Console.WriteLine("--- Portfolio Performance Breakdown ---");
            Console.WriteLine($"Stocks/Indices: ${stocks:F2}");
            Console.WriteLine($"Commodities: ${commodities:F2}");
            Console.WriteLine($"Cryptocurrencies: ${crypto:F2}");
        }
    }
}
