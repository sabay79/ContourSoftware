// Database seeding

using ContosoPizza.Models;

namespace ContosoPizza.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PizzaContext dbContext)
        {
            if(dbContext.Pizzas.Any()
            && dbContext.Toppings.Any()
            && dbContext.Sauces.Any())
            {
                return;
            }
            // DB has been seeded // 

            var pepperoniTopping = new Topping { Name = "Pepperoni", Calories = 130 }; 
            var sausageTopping = new Topping { Name = "Sausage", Calories = 100 };
            var chickenTopping = new Topping { Name = "Chicken", Calories = 50 };

            var tomatoSauce = new Sauce { Name = "Tomato", IsVegan = true };
            var alfredoSauce = new Sauce { Name = "Alfredo", IsVegan = false };

            var pizzas = new Pizza[]
            {
                new Pizza
                {
                    Name = "Pizza 1",
                    Sauce = tomatoSauce,
                    Toppings = new List<Topping> { pepperoniTopping, chickenTopping, sausageTopping }
                },
                new Pizza
                {
                    Name = "Pizza 2",
                    Sauce = tomatoSauce,
                    Toppings = new List<Topping> { chickenTopping }
                },
                new Pizza
                {
                    Name = "Pizza 3",
                    Sauce = alfredoSauce,
                    Toppings = new List<Topping> {pepperoniTopping, chickenTopping }
                }
            };

            dbContext.Pizzas.AddRange(pizzas);
            dbContext.SaveChanges();
        }
    }
    /*
    DbInitializer class and Initialize method are both defined as static
    Initialize accepts a PizzaContext as a parameter
    If there are no records in any of the three tables, Pizza, Sauce, and Topping objects are created
    The Pizza objects (and their Sauce and Topping navigation properties) are added to the object graph with AddRange
    The object graph changes are committed to the database with SaveChanges
    */
}