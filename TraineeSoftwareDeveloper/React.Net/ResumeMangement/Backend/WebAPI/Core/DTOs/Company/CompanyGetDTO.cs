using WebAPI.Core.Enums;

namespace WebAPI.Core.DTOs.Company
{
    public class CompanyGetDTO
    {
        public long ID { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Name { get; set; }

        public ComapnySize Size { get; set; }
    }
}
