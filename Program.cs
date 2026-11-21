

class Program
{
    static void Main()
    {
        static decimal ReadAmount()
        {
            while (true)
            {
                Console.Write("Enter amount: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
                {
                    return amount;
                }
                Console.WriteLine("Please type a positive number!");
            }
        }
        string name = "";
        while (string.IsNullOrWhiteSpace(name))
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
        }
        BankAccount account = new BankAccount(name);
        Console.WriteLine($"Name of account owner is: {account.Owner}");
        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Deposit Amount.");
            Console.WriteLine("2. Withdraw Amount.");
            Console.WriteLine("3. Show Balance.");
            Console.WriteLine("4. Exit.");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                decimal amount = ReadAmount();

                if (account.Deposit(amount))
                { Console.WriteLine($"Deposited amount: {amount:F2}"); }
                else
                {
                    Console.WriteLine("Deposit failed!");
                }
                account.ShowBalance();

            }
            else if (choice == "2")
            {
                decimal amount = ReadAmount();


                if (account.Withdraw(amount))
                {
                    Console.WriteLine($"Withdrawal Amount: {amount:F2}");

                }
                else
                {
                    Console.WriteLine("Insufficient Funds!");
                }
                account.ShowBalance();


            }
            else if (choice == "3")
            {
                account.ShowBalance();

            }
            else if (choice == "4")
            {
                Console.WriteLine("Exit");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
}
