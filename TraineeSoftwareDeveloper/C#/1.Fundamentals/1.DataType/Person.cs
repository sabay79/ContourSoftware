namespace _1.DataType
{
    public class Person
    {
        private int Id;
        private string Name;
        private int Age;

        // Default Constructor
        public Person()
        {
            Id = 1;
            Name = "Saba";
            Age = 23;
        }

        // Parameterized Constructor
        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        // Printing Method
        public (string name, int age) Display() => (Name, Age);
    }
}
