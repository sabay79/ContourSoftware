using WebAPI.Core.Enums;

namespace WebAPI.Core.DTOs.Company
{
    public class CompanyCreateDTO
    {
        public string Name { get; set; } = String.Empty;

        public ComapnySize Size { get; set; }
    }
}
