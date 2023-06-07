namespace ContactsAPI.Models
{
    public class Contact
    {
        public string Email { get; set; }
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
    }
}
