namespace LeaveManagment.Web.Data
{
    public abstract class BaseEntiy
    {
        public int Id { get; set; }

        public DateTime DataCreated { get; set; }

        public DateTime DataModified { get; set; }

    }
}
