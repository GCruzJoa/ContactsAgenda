using Contact_Agenda;
using Contacts_Agenda.Models;
using Contacts_Agenda.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Contacts_Agenda.ViewModels
{
    public class AddContactViewModel : BaseViewModel
    {
        public ObservableCollection<Contact> Contacts { get; }
        public ICommand OnAddCommand { get; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public AddContactViewModel(ObservableCollection<Contact> contacts)
        {
            this.Contacts = contacts;
            OnAddCommand = new Command(OnAddContact);
        }

        private async void OnAddContact()
        {
            Contacts.Add(new Contact(Name, PhoneNumber));
            await App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
