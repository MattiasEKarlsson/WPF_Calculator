using System;
using System.Collections.Generic;
using System.Text;

namespace ContactList
{
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public Contact(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
    }
}
