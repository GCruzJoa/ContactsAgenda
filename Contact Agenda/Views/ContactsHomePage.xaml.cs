using Contacts_Agenda.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contacts_Agenda.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsHomePage : ContentPage
    {
        public ContactsHomePage()
        {
            InitializeComponent();
            BindingContext = new ContactsHomeViewModel();
        }
    }
}