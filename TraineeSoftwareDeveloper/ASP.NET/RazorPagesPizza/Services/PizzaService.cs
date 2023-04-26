using RazorPagesPizza.Models;

namespace RazorPagesPizza.Services;
public static class PizzaService
{
    static List<Pizza> Pizzas { get; }
    static int nextID = 3;
    static PizzaService()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza { ID=1, Name="Classic Italian", Price=20.00M, Size=PizzaSize.Large, IsGlutenFree=false },
            new Pizza { ID=2, Name="Veggie", Price=10.00M, Size=PizzaSize.Small, IsGlutenFree=true }
        };
    }
    public static List<Pizza> GetAll() => Pizzas;
    public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.ID == id);
    public static void Add(Pizza pizza)
    {
        pizza.ID = nextID++;
        Pizzas.Add(pizza);
    }
    public static void Delete(int id)
    {
        var pizza = Get(id);
        if(pizza is null) {return;}

        Pizzas.Remove(pizza);
    }
    public static void Update(Pizza pizza)
    {
        var index = Pizzas.FindIndex(p => p.ID == pizza.ID);
        if(index == -1) {return;}

        Pizzas[index] = pizza;
    }
}
/* 
This service provides a simple in-memory data caching service with two pizzas by default 
that your web app will use for demo purposes. 
When you stop and start the web app, the in-memory data cache will be reset to the two default pizzas from the constructor of the PizzaService. 
*/