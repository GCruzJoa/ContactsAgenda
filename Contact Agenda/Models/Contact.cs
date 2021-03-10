using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Contacts_Agenda.Models 
{
    public class Contact : INotifyPropertyChanged
    {
        public Contact(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
