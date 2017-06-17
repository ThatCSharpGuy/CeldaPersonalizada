using System;

using Foundation;
using UIKit;
using Xamarin.Forms;
using FormsContactCell = CeldaPersonalizada.Cells.ContactCell;

namespace CeldaPersonalizada.iOS.Cells
{
    public partial class ContactCell : UITableViewCell, INativeElementView
    {
        public static readonly NSString Key = new NSString("ContactCell");
        public static readonly UINib Nib;

        static ContactCell()
        {
            Nib = UINib.FromName("ContactCell", NSBundle.MainBundle);
        }

        protected ContactCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public FormsContactCell FormsContactCell { get; set; }

        public void UpdateCell(string newName)
        {
            FirstLetter.Text = newName.Substring(0, 1);
            FullName.Text = newName;

        }

        public Element Element => FormsContactCell;
    }
}
