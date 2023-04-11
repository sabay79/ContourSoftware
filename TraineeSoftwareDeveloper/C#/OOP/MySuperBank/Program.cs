using MySuperBank;

Console.WriteLine("---------- MY SUPER BANK ----------");
var account = new BankAccount("Saba", 30000);
// String Interpolation
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

account.MakeWithdrawal(1000, DateTime.Now, "Saba");
Console.WriteLine(account.Balance);