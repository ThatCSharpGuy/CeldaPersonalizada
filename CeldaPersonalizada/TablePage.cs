using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CeldaPersonalizada
{
    public class TablePage : ContentPage
    {
        public TablePage()
        {
            var table = new TableView();
            var contactsSection = new TableSection("Contactos") {};
            foreach (var nombre in App.Nombres)
            {
                contactsSection.Add(new TextCell { Text = nombre });
            }
            var root = new TableRoot
            {
                contactsSection
            };
            table.Root = root;
            Content = table;
        }
    }
}
