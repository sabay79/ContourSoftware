using ContosoPizza.Models;
using ContosoPizza.Data;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Services;

public class PizzaService
{
    private readonly PizzaContext _dbContext;
    public PizzaService(PizzaContext dbContext)
    {
        _dbContext = dbContext;
    }
    // When the PizzaService instance is created, a PizzaContext will be injected as a dependency.
    public IEnumerable<Pizza> GetAll()
    {
        return _dbContext.Pizzas
        .AsNoTracking()
        .ToList();

        // AsNoTracking extension method instructs EF Core to disable change tracking. Since this operation is read-only, AsNoTracking can optimize performance.
    }

    public Pizza? GetById(int id)
    {
        return _dbContext.Pizzas
        .Include(p=>p.Toppings)
        .Include(p=>p.Sauce)
        .AsNoTracking()
        .SingleOrDefault(p=>p.Id == id);

        /*
        Include extension method takes a lambda expression to specify that 
        the Toppings and Sauce navigation properties are to be included in the result (eager loading). 
        Without this, EF Core will return null for those properties.
        
        SingleOrDefault method returns a pizza that matches the lambda expression
        - If no records match, null is returned.
        - If multiple records match, an exception is thrown.
        - The lambda expression describes records where the Id property is equal to the id parameter
        */
    }

    public Pizza? Create(Pizza newPizza)
    {
        _dbContext.Pizzas.Add(newPizza);
        _dbContext.SaveChanges();

        return newPizza;

        /*
        newPizza is assumed to be a valid object. 
        EF Core doesn't do data validation, so any validation must be handled by the ASP.NET Core runtime or user code.

        Add method adds the newPizza entity to EF Core's object graph
        SaveChanges method instructs EF Core to persist the object changes to the database
        */
    }

    public void AddTopping(int PizzaId, int ToppingId)
    {
        var pizzaToUpdate = _dbContext.Pizzas.Find(PizzaId);
        var toppingToAdd = _dbContext.Toppings.Find(ToppingId);

        if (pizzaToUpdate is null || toppingToAdd is null)
        {
            throw new InvalidOperationException("Pizza or Topping doesnot exist.");
        }

        if(pizzaToUpdate.Toppings is null)
        {
            pizzaToUpdate.Toppings = new List<Topping>();
        }

        pizzaToUpdate.Toppings.Add(toppingToAdd);
        _dbContext.SaveChanges();

        /*
        References to an existing Pizza and Topping are created using Find
        Topping is added to the Pizza.Toppings collection with the .Add method. A new collection is created if it doesn't exist.
        */
    }

    public void UpdateSauce(int PizzaId, int SauceId)
    {
        var pizzaToUpdate = _dbContext.Pizzas.Find(PizzaId);
        var sauceToUpdate = _dbContext.Sauces.Find(SauceId);

        if(pizzaToUpdate is null || sauceToUpdate is null)
        {
            throw new InvalidOperationException("Pizza or Sauce doesnot exist.");
        }

        pizzaToUpdate.Sauce = sauceToUpdate;
        _dbContext.SaveChanges();

        /*
        Find is an optimized method to query records by their primary key. Find searches the local entity graph first before querying the database.
        Pizza.Sauce property is set to the Sauce object.
        Update method call is unnecessary because EF Core detects that we set the Sauce property on Pizza
        */
    }

    public void DeleteById(int id)
    {
        var pizzaToDelete = _dbContext.Pizzas.Find(id);
        if(pizzaToDelete is not null)
        {
            _dbContext.Pizzas.Remove(pizzaToDelete);
            _dbContext.SaveChanges();
        }
        
        /*
        Find method retrieves a pizza by the primary key (in this case, Id)
        Remove method removes the pizzaToDelete entity in EF Core's object graph
        SaveChanges method instructs EF Core to persist the object changes to the database
        */
    }
}