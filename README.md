# BankApp

A console bank application written in C# (.NET). It runs a text menu where a user can deposit money, withdraw money, and check the balance.

## Features

- Asks for the account owner's name at startup and rejects an empty name
- Menu with four options: deposit, withdraw, show balance, exit
- Input validation: letters, zero, and negative amounts are rejected, and the program asks again instead of crashing
- Withdrawals larger than the balance are refused, and withdrawing the exact balance works
- Money is stored as `decimal`, which avoids the rounding errors that `double` has (for example, 0.1 + 0.2)
- Balances are shown with two decimal places, like `300.00`

## Design

- `BankAccount.cs` holds the account logic: a constructor that requires an owner, a read-only `Owner`, and a `Balance` that can be read from anywhere but only changed inside the class
- `Deposit` and `Withdraw` return `true` or `false`, so the class checks its own rules and `Program.cs` decides what to show the user
- `Program.cs` handles all the input and output: the menu loop and a reusable `ReadAmount()` helper

## What I practiced

- Classes, objects, constructors, fields, and properties
- Methods with parameters and return values
- `while` loops, `if / else if / else`, and `decimal.TryParse` for safe input
- Encapsulation with `{ get; private set; }`
- Splitting code across files
- Git and GitHub

## How to run

1. Install the [.NET SDK](https://dotnet.microsoft.com/download)
2. Clone the repository:
   ```
   git clone https://github.com/mianallam/BankApp.git
   ```
3. Open a terminal in the project folder and run:
   ```
   dotnet run
   ```

## Example

```
Enter your name: mike
Name of account owner is: mike
1. Deposit Amount.
2. Withdraw Amount.
3. Show Balance.
4. Exit.
1
Enter amount: 500
Deposited amount: 500.00
Balance of mike is: 500.00
2
Enter amount: 200
Withdrawal Amount: 200.00
Balance of mike is: 300.00
```

## Possible next steps

- Support multiple accounts with account numbers
- Transfers between accounts
- Transaction history
- Saving accounts to a file or database
