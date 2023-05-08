namespace EntityFramework.Model
{
    public class Address
    {
        public Address(string street, string city, string postcode, string country)
        {
            Street = street;
            City = city;
            PostCode = postcode;
            Country = country;
        }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
    }
}