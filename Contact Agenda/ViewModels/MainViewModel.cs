using Contacts_Agenda.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_Agenda.ViewModels
{
    public class MainViewModel
    {
        public MenuOption Option1 => new MenuOption("Option 1", "First Option", "fastFood.png");
        public MenuOption Option2 => new MenuOption("Option 2", "Second Option", "fastFood.png");
        public MenuOption Option3 => new MenuOption("Option 3", "Third Option", "fastFood.png");
        public MenuOption Option4 => new MenuOption("Option 4", "Fourth Option", "fastFood.png");
        public MenuOption Option5 => new MenuOption("Option 5", "Fifth Option", "fastFood.png");
        public MenuOption Option6 => new MenuOption("Option 6", "Sixth Option", "fastFood.png");

        public MainViewModel()
        {

        }
    }
}
