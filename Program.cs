using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== ATM SYSTEM ===");

        // Get initial balance
        double balance = GetValidAmount("Enter your current balance: ");

        // Get withdrawal amount
        double withdrawal = GetValidAmount("Enter amount to withdraw: ");

        // Check if sufficient funds
        if (withdrawal > balance)
        {
            Console.WriteLine("\n❌ Insufficient funds!");
        }
        else
        {
            balance -= withdrawal;

            Console.WriteLine("\n=== Transaction Successful ===");
            Console.WriteLine($"Amount Withdrawn: R{withdrawal:F2}");
            Console.WriteLine($"Remaining Balance: R{balance:F2}");
            Console.WriteLine($"Transaction Time: {DateTime.Now}");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    // Method to validate numeric input
    static double GetValidAmount(string message)
    {
        double amount;

        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (double.TryParse(input, out amount) && amount >= 0)
            {
                return amount;
            }
            else
            {
                Console.WriteLine("❌ Invalid input. Please enter a valid positive number.");
            }
        }
    }
}