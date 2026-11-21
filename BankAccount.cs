class BankAccount
{
    public string Owner { get; }
    public decimal Balance { get; private set; }
    public BankAccount(string owner)
    {
        Owner = owner;
    }
    public bool Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            return false;
        }
        else
        {
            Balance += amount;
            return true;
        }
    }
    public void ShowBalance()
    {
        Console.WriteLine($"Balance of {Owner} is: {Balance:F2} ");
    }
    public bool Withdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }
}