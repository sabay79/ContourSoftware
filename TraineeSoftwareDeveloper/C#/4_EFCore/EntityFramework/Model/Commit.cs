namespace EntityFramework.Model
{
    public class Commit
    {
        public Commit(DateTime committedOn, string comment)
        {
            CommittedOn = committedOn;
            Comment = comment;
        }
        public DateTime CommittedOn { get; private set; }
        public string Comment { get; set; }
    }
}