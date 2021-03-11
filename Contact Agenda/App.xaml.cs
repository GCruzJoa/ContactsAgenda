using Contacts_Agenda.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contact_Agenda
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ContactsHomePage());
            //MainPage = new GoogleUIPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
