﻿namespace ContactsAPI.Models
{
    public class AddContactRequest
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
    }
}
