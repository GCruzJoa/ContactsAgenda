using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_Agenda.Models
{
    public class Contact
    {
        public Contact(string name, string phoneNumber, string image)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Image = image;
        }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Image { get; set; }
    }
}
