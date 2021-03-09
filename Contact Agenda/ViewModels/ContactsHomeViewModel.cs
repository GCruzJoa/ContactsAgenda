using Contact_Agenda;
using Contacts_Agenda.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Contacts_Agenda.ViewModels
{
    public class ContactsHomeViewModel
    {
        public ObservableCollection<Contact> Contacts { get; }

        public ICommand SelectedContactCommand { get; }

        public ICommand AddContact { get; }

        private Contact _contact;
        public Contact SelectedContact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
                if (_contact != null)
                {
                    SelectedContactCommand.Execute(_contact);
                }                
            }
        }

        public ContactsHomeViewModel()
        {
            Contacts = new ObservableCollection<Contact>
            {
                new Contact("Gabriel", "6856", "fastFood.png"),
                new Contact("Katherine", "4576", "fastFood.png")
            };
            SelectedContactCommand = new Command<Contact>(OnContactSelected);
            AddContact = new Command(OnAddContactSelected);
        }

        private void OnAddContactSelected()
        {
            Contacts.Add(new Contact("Jaydi","84968","fastFood.png"));
        }

        private async void OnContactSelected(Contact contact)
        {
            await App.Current.MainPage.DisplayAlert("Contact", contact.Name, "Ok");
        }
    }
}
