using OBS.Data;
//using OBS.Data.Interfaces;
//using OBS.Data.Models;
//using OBS.Data.Services;

try
{
    using var _dbContext = new BookStoreDbContext();
    BookStoreDbInitializer.Initialize(_dbContext);
    Console.WriteLine("Database seeding Successfull.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message.ToString());
}

// REPOSITORY PATTERN //
// Repository Pattern promotes a clean separation of concerns
// and improves the maintainability, testability, and flexibility of applications by abstracting away the data access implementation details.

// Test Customer Repository // 

//var customerRepository = new CustomerRepository();

//var customers = customerRepository.GetAll();
//foreach (var customer in customers)
//{
//    Console.WriteLine($"Customer: {customer.Name},\t Gender:{customer.Gender}");
//}
//try
//{
//    var customerByID = customerRepository.GetByID(1);
//    Console.WriteLine($"Customer: {customerByID.Name},\t Gender:{customerByID.Gender}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message.ToString());
//}

//try
//{
//    var customerToAdd = new Customer { Name = "Ayesha", Gender = Gender.Female, Email = "ayesha@gmail.com", Address = "Pakistan" };
//    customerRepository.Add(customerToAdd);
//    customerRepository.Save();
//    Console.WriteLine(customerToAdd.ID);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message.ToString());
//}

//try
//{
//    customerRepository.Delete(9);
//    customerRepository.Save();
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message.ToString());
//}

//try
//{
//    var customerToUpdate = customerRepository.GetAll().First();
//    customerToUpdate.Email = "sabay@gmail.com";
//    customerRepository.Save();
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message.ToString());
//}



// UNIT OF WORK - UOW //
// Unit of Work is referred to as a single transaction that involves multiple operations of insert/update/delete and so on kinds.
// To say it in simple words, it means that for specific user action (say registration on a website),
// all the transactions like insert/update/delete and so on are done in one single transaction, rather than doing multiple database transactions.
// This means, one unit of work here involves insert/update/delete operations, all in one single transaction.
