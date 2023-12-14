using WebAPI.Core.Enums;

namespace WebAPI.Core.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; } = String.Empty;

        public ComapnySize Size { get; set; }

        public ICollection<Job> Jobs { get; set; }

        public Company()
        {
            Jobs = new List<Job>();
        }
    }
}
