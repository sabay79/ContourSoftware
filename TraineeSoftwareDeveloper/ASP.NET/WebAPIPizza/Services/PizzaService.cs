using WebAPIPizza.Models;

namespace WebAPIPizza.Services;

public static class PizzaService
{
    static List<Pizza>? Pizzas { get; }
    static int nextID = 3;
    static PizzaService()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza { ID = 1, Name = "Pizza 1", IsGlutenFree = false },
            new Pizza { ID = 2, Name = "Pizza 2", IsGlutenFree = true }
        };
    }

    public static List<Pizza>? GetAll() => Pizzas;
    public static Pizza? Get(int id) => Pizzas?.FirstOrDefault( p => p.ID == id);
    public static void Add(Pizza pizza)
    {
        pizza.ID = nextID++;
        Pizzas?.Add(pizza);
    }
    public static void Delete(int id)
    {
        var pizza = Get(id);
        if(pizza is null)
            return;
        
        Pizzas?.Remove(pizza);
    }
    public static void Update(Pizza pizza)
    {
        var index = Pizzas.FindIndex( p => pizza.ID == pizza.ID);
        if(index == -1)
            return;
        
        Pizzas[index] = pizza;
    }
}