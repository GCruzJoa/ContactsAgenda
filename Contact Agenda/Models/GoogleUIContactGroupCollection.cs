using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Contacts_Agenda.Models
{
    public class GoogleUIContactGroupCollection : ObservableCollection<Contact>
    {
        public string Key { get; }

        public GoogleUIContactGroupCollection(string key)
        {
            Key = key;
        }
    }
}
