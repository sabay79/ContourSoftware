namespace PartialClass
{
    public partial class StudentPartial
    {
        public string GetFullName() => _firtsName + " " + _lastName;
        // Can access private members as well bcz they are present in another part of this class which is stored in StudentPartial1.cs file
    }
}
