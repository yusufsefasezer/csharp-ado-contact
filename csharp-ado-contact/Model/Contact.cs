namespace csharp_ado_contact
{
    public class Contact
    {
        public int contactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string WebAddress { get; set; }
        public string Notes { get; set; }
    }
}
