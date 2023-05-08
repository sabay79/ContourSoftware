using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ContosoPizza.Models;

public class Topping
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string? Name { get; set; }
    public decimal Calories { get; set; }

    [JsonIgnore]
    // To prevent Topping entities from including the Pizzas property when the web API code serializes the response to JSON
    public ICollection<Pizza>? Pizzas { get; set; }
}