using System;
using Xamarin.Forms.Platform.iOS;
using iOSContactCell = CeldaPersonalizada.iOS.Cells.ContactCell;
using FormsContactCell = CeldaPersonalizada.Cells.ContactCell;
using Xamarin.Forms;
using System.Linq;

[assembly: ExportRenderer(typeof(FormsContactCell), typeof(CeldaPersonalizada.iOS.Cells.ContactCellRenderer))]
namespace CeldaPersonalizada.iOS.Cells
{
    public class ContactCellRenderer : ViewCellRenderer
    {
        iOSContactCell _nativeContactCell;

        public override UIKit.UITableViewCell GetCell(Xamarin.Forms.Cell item, UIKit.UITableViewCell reusableCell, UIKit.UITableView tv)
        {
            _nativeContactCell = reusableCell as iOSContactCell;
            if (_nativeContactCell == null)
            {
                var stuff = iOSContactCell.Nib.Instantiate(null, null);
                _nativeContactCell = stuff.First() as iOSContactCell;
            } else
            {
                _nativeContactCell.FormsContactCell.PropertyChanged -= FormsContactCell_PropertyChanged;    
            }
            _nativeContactCell.FormsContactCell = item as FormsContactCell;
            _nativeContactCell.FormsContactCell.PropertyChanged += FormsContactCell_PropertyChanged;
            _nativeContactCell.UpdateCell((item as FormsContactCell).ContactName);

            return _nativeContactCell;
        }

        void FormsContactCell_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var formsCell = sender as FormsContactCell;
            if(e.PropertyName.Equals("ContactName"))
            {
                _nativeContactCell.UpdateCell(formsCell.ContactName);
            }
        }
    }
}
