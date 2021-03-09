using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Contacts_Agenda.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel()
        {

        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
