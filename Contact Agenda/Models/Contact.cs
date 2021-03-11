using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Contacts_Agenda.Models 
{
    public class Contact : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Image => "user.png";

        public Contact(string name)
        {
            Name = name;
        }

        public Contact(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
