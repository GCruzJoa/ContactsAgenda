using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_Agenda.Models
{
    public class MenuOption
    {
        public MenuOption(string tittle, string detail, string image)
        {
            Tittle = tittle;
            Detail = detail;
            Image = image;
        }

        public string Tittle { get; }
        public string Detail { get; }
        public string Image { get; }
    }
}
