using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoApp.WebAPI.Data
{
    [Table("Note")]
    public class Note
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
