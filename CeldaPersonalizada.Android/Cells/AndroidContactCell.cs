using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using CeldaPersonalizada.Cells;

namespace CeldaPersonalizada.Droid.Cells
{
    public class AndroidContactCell : LinearLayout, INativeElementView
    {
        ContactCell _nativeContactCell;
        public Element Element => _nativeContactCell;

        TextView _firstLetterTextView;
        TextView _fullNameTextView;

        public AndroidContactCell(Context context, ContactCell cell) : base(context)
        {
            _nativeContactCell = cell;

            var view = (context as Activity).LayoutInflater.Inflate(Resource.Layout.ContactCell, null);
            _firstLetterTextView = view.FindViewById<TextView>(Resource.Id.FirstLetter);
            _fullNameTextView = view.FindViewById<TextView>(Resource.Id.FullName);

            AddView(view);
        }

        public void UpdateCell(string newName)
        {
            _firstLetterTextView.Text = newName.Substring(0, 1);
            _fullNameTextView.Text = newName;

        }
    }
}