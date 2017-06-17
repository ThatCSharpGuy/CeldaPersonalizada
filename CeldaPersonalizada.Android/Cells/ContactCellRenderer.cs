using Android.Content;
using Android.Views;
using Xamarin.Forms;
using CeldaPersonalizada.Cells;
using CeldaPersonalizada.Droid.Cells;
using Xamarin.Forms.Platform.Android;
using System.ComponentModel;
using AndroidRelativeLayout = Android.Widget.RelativeLayout;
using TextView = Android.Widget.TextView;

[assembly: ExportRenderer(typeof(ContactCell), typeof(ContactCellRenderer))]
namespace CeldaPersonalizada.Droid.Cells
{
    class ContactCellRenderer : ViewCellRenderer
    {
        AndroidContactCell _cell;

        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
        {
            var formsCell = Cell as ContactCell;
            _cell = convertView as AndroidContactCell;
            if (_cell == null)
            {
                _cell = new AndroidContactCell(context, formsCell);
            }

            _cell.UpdateCell(formsCell.ContactName);

            return _cell;
        }

        protected override void OnCellPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var formsCell = (ContactCell)sender;
            if (e.PropertyName.Equals("ContactName"))
            {
                _cell.UpdateCell(formsCell.ContactName);
            }
        }
    }
}