using MySuperBank;

Console.WriteLine("---------- MY SUPER BANK ----------");
var account = new BankAccount("Saba", 30000);
// String Interpolation
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

account.MakeWithdrawal(1000, DateTime.Now, "Saba");
Console.WriteLine(account.Balance);

// Transaction Log
Console.WriteLine(account.GetAccountHistory());


// Catching Exceptions //

// Test that the initial balance must be positive
try
{
    var invalidAccount = new BankAccount("Invalid", -1000);
}
// Exception: if you'll catch it, you do not blow up your entire program
catch(ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negetive balance");
    //Console.WriteLine(e.Message);
    Console.WriteLine(e.ToString());    
}

// Test for negetive balance
try 
{
    account.MakeWithdrawal(50000, DateTime.Now, "Attempt to withdraw");
}
catch(InvalidOperationException e)
{
    Console.WriteLine("Exception caught trying to withdraw");
    Console.WriteLine(e.ToString());
}

// Just to check whether exception stops further execution?: NO, if it's caught 
account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");
Console.WriteLine(account.Balance); 