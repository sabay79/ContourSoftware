using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using RazorPagesPizza.Models;
using RazorPagesPizza.Services;

namespace RazorPagesPizza.Pages
{
    public class PizzaModel : PageModel
    {
        [BindProperty]
        public Pizza? NewPizza { get; set; } = new();      
        public List<Pizza> pizzas = new();

        // Update the HTTP Get page handler to display the list of Pizzas //

        // Update the OnGet page handler
        public void OnGet()
        {
            pizzas = PizzaService.GetAll();
        }
        // Use a utility method to format the Gluten Free information in the list
        public string GlutenFree(Pizza pizza)
        {
            return pizza.IsGlutenFree ? "Gluten Free" : "Not Gluten Free";
        }
 
        // Add an HTTP POST page handler to the PageModel //
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            PizzaService.Add(NewPizza);
            return RedirectToAction("Get");
        }

        // Add an HTTP POST handler for the Delete buttons //
        public IActionResult OnPostDelete(int id)
        {
            PizzaService.Delete(id);
            return RedirectToAction("Get");
        }
    }
}
