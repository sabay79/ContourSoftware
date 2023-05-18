using OBS.Data.Models;

namespace OBS.Data
{
    public class BookStoreDbInitializer
    {
        public static void Initialize(BookStoreDbContext dbContext)
        {
            // Look for any Book
            if (dbContext.Books.Any())
            {
                return;
                //DB has been seeded
            }

            var banoQudsia = new Author
            {
                Name = "Bano Qudsia",
                Gender = Gender.Female,
                Email = "bq@email.com",
            };
            var amjadislamAmjad = new Author
            {
                Name = "Amjad Islam Amjad",
                Gender = Gender.Male,
                Email = "aia@email.com"
            };
            var authorX = new Author
            {
                Name = "Autor X",
                Gender = Gender.Male,
                Email = "ia@email.com"
            };
            var authorY = new Author
            {
                Name = "Author Y",
                Gender = Gender.Female,
                Email = "ah@email.com"
            };
            var authors = new List<Author> { banoQudsia, amjadislamAmjad, authorX, authorY };
            dbContext.Authors.AddRange(authors);

            var sang_e_meel = new Publisher
            {
                Name = "Sang-e-Meel",
                Email = "smp@sangemeel.com",
                Address = "Sang-e-meel Publications, 25 Lower Mall, Lahore, Pakistan"
            };
            var auraq = new Publisher
            {
                Name = "Auraq",
                Email = "auraq@email.com",
                Address = "BS-6, Satti Plaza, Stadium Road, Rawalpindi, Pakistan"
            };
            var publishers = new List<Publisher> { sang_e_meel, auraq };
            dbContext.Publishers.AddRange(publishers);

            var yehAfsanay = new Book
            {
                Title = "Yeh Afsanay",
                ISBN = 1111,
                Price = 1000,
                Year = DateTime.Parse("1992-01-01"),
                Authors = new List<Author> { amjadislamAmjad },
                Publisher = sang_e_meel
            };
            var haasilGhaat = new Book
            {
                Title = "Haasil Ghaat",
                ISBN = 1112,
                Price = 2000,
                Year = DateTime.Parse("2005-01-01"),
                Authors = new List<Author> { banoQudsia },
                Publisher = sang_e_meel
            };
            var bookXY = new Book
            {
                Title = "Book by X & Y",
                ISBN = 1113,
                Price = 5000,
                Year = DateTime.Parse("2023-01-01"),
                Authors = new List<Author> { authorX, authorY },
                Publisher = auraq
            };
            var books = new List<Book> { yehAfsanay, haasilGhaat, bookXY };
            dbContext.Books.AddRange(books);

            var saba = new Customer
            {
                Name = "Saba",
                Gender = Gender.Female,
                Email = "saba@gmail.com",
                Address = "Pakistan"
            };
            dbContext.Customers.Add(saba);

            var order1 = new Order
            {
                OrderDate = DateTime.Parse("2023-03-21"),
                OrderStatus = OrderStatus.Delivered,
                PaymentMethod = PaymentMethod.CashOnDelivery,
                DeliveryDate = DateTime.Parse("2023-03-31"),
                DeliveryCharges = 200,
                Customer = saba,
                OrderItems = new List<OrderItem>
                {
                    new OrderItem
                    {
                        Book = haasilGhaat,
                        Quantity = 1
                    },
                    new OrderItem
                    {
                        Book = yehAfsanay,
                        Quantity = 2
                    }
                }
            };
            var order2 = new Order
            {
                OrderDate = DateTime.Parse("2023-04-21"),
                OrderStatus = OrderStatus.Pending,
                PaymentMethod = PaymentMethod.CashOnDelivery,
                DeliveryDate = DateTime.Parse("2023-05-30"),
                DeliveryCharges = 200,
                Customer = saba
            };
            var orders = new List<Order> { order1, order2 };
            dbContext.Orders.AddRange(orders);

            var order1Item1 = new OrderItem
            {
                Order = order1,
                Book = bookXY,
                Quantity = 3
            };
            var order2Item1 = new OrderItem
            {
                Order = order2,
                Book = haasilGhaat,
                Quantity = 1
            };
            var order2Item2 = new OrderItem
            {
                Order = order2,
                Book = yehAfsanay,
                Quantity = 2
            };

            var orderItems = new List<OrderItem> { order1Item1, order2Item1, order2Item2 };
            dbContext.OrderItems.AddRange(orderItems);

            dbContext.SaveChanges();
        }
    }
}
