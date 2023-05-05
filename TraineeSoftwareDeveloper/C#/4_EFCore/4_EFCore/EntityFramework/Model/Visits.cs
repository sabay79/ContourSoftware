namespace EntityFramework.Model
{
    public class Visits
    {
        public Visits(double latitude, double longitude, int count)
        {
            Latitude = latitude;
            Longitude = longitude;
            Count = count;
        }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public int Count { get; private set; }
        public List<string>? Browsers { get; set; }
    }
}