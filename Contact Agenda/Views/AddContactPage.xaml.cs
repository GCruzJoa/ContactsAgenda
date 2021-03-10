using Contacts_Agenda.Models;
using Contacts_Agenda.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contacts_Agenda.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactPage : ContentPage
    {
        public AddContactPage(ObservableCollection<Contact> Contacts)
        {
            InitializeComponent();
            BindingContext = new AddContactViewModel(Contacts);
        }
    }
}