namespace PartialClass
{
    public partial class StudentPartial
    {
        private string _firtsName;
        private string _lastName;

        public string FirstName
        {
            set { _firtsName = value; }
            get { return _firtsName; }
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }
    }
}
