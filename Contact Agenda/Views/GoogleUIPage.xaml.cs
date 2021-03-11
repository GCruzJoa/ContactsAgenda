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
    public partial class GoogleUIPage : ContentPage
    {
        public GoogleUIPage()
        {
            InitializeComponent();
            BindingContext = new GoogleUIViewModel();
        }

        void ListView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;
            ((ListView)sender).SelectedItem = null;
        }
    }
}