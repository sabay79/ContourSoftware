// EXCEPTION HANDLING //
// https://www.youtube.com/watch?v=RmbXGAo2ANE&list=PLX07l0qxoHFLZftsVKyj3k9kfMca2uaPR&index=103

// Case - Our Throw, Our Catch ***
int accountBalance = 50000;
int withDrawlAmount = 100000;

try
{
    if (accountBalance < withDrawlAmount)
    {
        throw new Exception("Insufficient Balance");
    }
    else
    {
        accountBalance = accountBalance - withDrawlAmount;
        Console.WriteLine("Remaining Balance is " + accountBalance);
        Console.WriteLine("Transaction Completed Successfully");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}