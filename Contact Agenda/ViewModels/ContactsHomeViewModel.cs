using Contact_Agenda;
using Contacts_Agenda.Models;
using Contacts_Agenda.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Contacts_Agenda.ViewModels
{
    public class ContactsHomeViewModel : BaseViewModel
    {
        public ObservableCollection<Contact> Contacts { get; }

        public ICommand AddCommand { get; }

        public ICommand MoreCommand { get; }

        public ICommand DeleteCommand { get; }
       

        public ContactsHomeViewModel()
        {
            Contacts = new ObservableCollection<Contact>
            {
            };
                       
            AddCommand = new Command(OnAddContact);
            MoreCommand = new Command<Contact>(OnMoreTapped);
            DeleteCommand = new Command<Contact>(OnDeleteContact);
        }

        private async void OnMoreTapped(Contact contact)
        {
            string optionSelected = await App.Current.MainPage.DisplayActionSheet(null, "Cancel", null, "Call +" + contact.PhoneNumber, "Edit");
            if (optionSelected == "Call +" + contact.PhoneNumber)
            {
                try
                {
                    PhoneDialer.Open(contact.PhoneNumber);
                }
                catch (Exception)
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "Was not possible to call the contact", "Ok");
                }
            }
            else if (optionSelected == "Edit")
            {
                int newIndex = Contacts.IndexOf(contact);
                var name = await App.Current.MainPage.DisplayPromptAsync("Edit Name", "Type the contact's new name", "Ok");
                var phoneNumber = await App.Current.MainPage.DisplayPromptAsync("Edit Number", "Type the contact's new number", "Ok", keyboard: Keyboard.Numeric);
                OnDeleteContact(contact);
                                
                Contacts.Add(new Contact(name, phoneNumber));
                int oldIndex = Contacts.Count - 1;

                Contacts.Move(oldIndex, newIndex);
            }
        }

        private void OnDeleteContact(Contact contact)
        {
            Contacts.Remove(contact);
        }

        private async void OnAddContact()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AddContactPage(Contacts));
        }
    }
}
