using Contact_Agenda;
using Contacts_Agenda.Models;
using Contacts_Agenda.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Contacts_Agenda.ViewModels
{
    public class GoogleUIViewModel : BaseViewModel
    {
        public ObservableCollection<GoogleUIContactGroupCollection> Contacts { get; }

        public string Name { get; }

        public ICommand AddCommand { get; }

        public GoogleUIViewModel()
        {
            AddCommand = new Command(OnAddContact);

            Contacts = new ObservableCollection<GoogleUIContactGroupCollection>()
            {
                new GoogleUIContactGroupCollection("Favoritos")
                {
                    new Contact("Gabriel"),
                    new Contact("Alejandro")
                },
                new GoogleUIContactGroupCollection("A")
                {
                    new Contact("Abraham"),
                    new Contact("Alberto"),
                    new Contact("Alejandro"),
                    new Contact("Alexandra")
                },
                new GoogleUIContactGroupCollection("B")
                {
                    new Contact("Bodega La Solucion"),
                    new Contact("Barbero 15"),
                    new Contact("Bruno"),
                    new Contact("Berthold")
                },
                new GoogleUIContactGroupCollection("C")
                {
                    new Contact("Candy"),
                    new Contact("Carlos"),
                    new Contact("Chris")
                },
                new GoogleUIContactGroupCollection("D")
                {
                    new Contact("Dante"),
                    new Contact("David"),
                    new Contact("Darling"),
                    new Contact("Darcy")
                },
                new GoogleUIContactGroupCollection("E")
                {
                    new Contact("Eren"),
                    new Contact("Ernesto"),
                    new Contact("Emilio")
                }
            };
        }

        private async void OnAddContact()
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new GoogleAddPage());
        }
    }
}
