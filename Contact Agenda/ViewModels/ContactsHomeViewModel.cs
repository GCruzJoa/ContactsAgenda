using Contact_Agenda;
using Contacts_Agenda.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Contacts_Agenda.ViewModels
{
    public class ContactsHomeViewModel : BaseViewModel
    {
        public ObservableCollection<ContactGroupCollection> Contacts { get; }

        public ICommand SelectedContactCommand { get; }

        public ICommand AddContact { get; }

        public bool IsBusy { get; set; }

        public ICommand RefreshCommand { get; }

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
            Contacts = new ObservableCollection<ContactGroupCollection>()
            {
                new ContactGroupCollection("Favoritos")
                {
                    new Contact("Gabriel", "6856", "fastFood.png"),
                    new Contact("Katherine", "4576", "fastFood.png")
                },
                new ContactGroupCollection("Contactos")
                {
                    new Contact("Javier", "09821", "fastFood.png"),
                    new Contact("Jaydi", "2376", "fastFood.png")
                }
            };
                       
            SelectedContactCommand = new Command<Contact>(OnContactSelected);
            AddContact = new Command(OnAddContactSelected);
            RefreshCommand = new Command(OnAddContactSelected);
        }

        private async void OnAddContactSelected()
        {
            IsBusy = true;
            await Task.Delay(2000);

            var contactGroup = Contacts.FirstOrDefault(prop => prop.Key == "Favoritos");
            if (contactGroup == null)
            {
                Contacts.Add(new ContactGroupCollection("Favoritos")
                {
                    new Contact("Alejandro", "341320","fastFood.png")
                });
            }
            else
            {
                contactGroup.Add(new Contact("Alejandro", "341320", "fastFood.png"));
            }            
            IsBusy = false;
        }

        private async void OnContactSelected(Contact contact)
        {
            await App.Current.MainPage.DisplayAlert("Contact", contact.Name, "Ok");
        }
    }
}
