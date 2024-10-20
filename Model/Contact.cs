namespace dotnet_appWebApi.Model
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
        public DateTime DateCreatedOn { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; } = false;
    }
}
