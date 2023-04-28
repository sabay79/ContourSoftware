using WebAPIPizza.Models;
using WebAPIPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIPizza.Controllers;

// ControllerBase, the base class for working with HTTP requests in ASP.NET Core. 
// It also includes the two standard attributes you've learned about: [ApiController] and [Route]. 
// As before, the [Route] attribute defines a mapping to the [controller] token. Because this controller class is named PizzaController, this controller handles requests to https://localhost:{PORT}/pizza.

[ApiController]
[Route("Pizza")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {}

    // GET - Read - [HttpGet] //
    // Get all pizzas
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

    // Retrieve a single pizza
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);
        if(pizza is null)
            return NotFound();
            // NotFound	- 404 - A product that matches the provided id parameter doesn't exist in the in-memory cache.

        return pizza;
    }

    // POST - Create - [HttpPost] //
    // Add a pizza
    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        PizzaService.Add(pizza);
        return CreatedAtAction(nameof(Get), new { id = pizza.ID }, pizza);
    }

    // PUT - Update - [HttpPut] //
    // Modify a pizza
    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {
        if (id != pizza.ID)
            return BadRequest();
            
        var existingPizza = PizzaService.Get(id);
        if(existingPizza is null)
            return NotFound();
    
        PizzaService.Update(pizza);           
    
        return NoContent();
    }
    // DELETE - Delete - [HttpDelete] //
    // Remove a pizza
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var pizza = PizzaService.Get(id);
    
        if (pizza is null)
            return NotFound();
        
        PizzaService.Delete(id);
    
        return NoContent();
    }
}