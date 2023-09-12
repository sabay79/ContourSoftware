using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoApp.WebAPI.Data
{
    [Table("Note")]
    public class Note
    {
        public Guid Id { get; set; } = Guid.Parse("bd0c16cd-e1ef-4694-8429-06870c4af0b9");
        public string Description { get; set; } = string.Empty;
    }
}
