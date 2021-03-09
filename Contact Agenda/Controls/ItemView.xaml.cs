using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Contacts_Agenda.Views;

namespace Contacts_Agenda.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemView : StackLayout
    {
        public ItemView()
        {
            InitializeComponent();
        }
    }
}