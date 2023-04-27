using Microsoft.AspNetCore.Mvc;
using RazorPagesPizza.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesPizza.Pages
{
    public class PizzaModel : PageModel
    {
    [BindProperty]
    public Pizza NewPizza { get; set; }        
    public List<Pizza> pizzas = new List<Pizza>();
        public void OnGet()
        {
        }
    }
}
