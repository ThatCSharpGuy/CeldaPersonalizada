using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CeldaPersonalizada
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ListPage()
        {
            InitializeComponent();
            MyList.ItemsSource = App.Nombres;
        }
    }
}