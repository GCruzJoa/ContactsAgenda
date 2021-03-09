using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Contacts_Agenda.Models
{
    public class ContactGroupCollection: ObservableCollection<Contact>
    {
        public ContactGroupCollection(string key)
        {
            Key = key;
        }
        public string Key { get; }
    }
}
