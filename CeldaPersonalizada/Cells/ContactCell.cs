using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CeldaPersonalizada.Cells
{
    public class ContactCell : ViewCell
    {

        public static readonly BindableProperty ContactNameProperty =
            BindableProperty.Create(nameof(ContactName), typeof(string), typeof(ContactCell), default(string));

        public string ContactName
        {
            get { return (string)GetValue(ContactNameProperty); }
            set { SetValue(ContactNameProperty, value); }
        }

        protected override void OnBindingContextChanged()
        {
            string name = BindingContext as string;
            if(name!= null)
            {
                ContactName = name;
            }
        }
    }
}
