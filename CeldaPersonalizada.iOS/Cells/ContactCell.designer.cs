// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CeldaPersonalizada.iOS.Cells
{
	[Register ("ContactCell")]
	partial class ContactCell
	{
		[Outlet]
		UIKit.UILabel FirstLetter { get; set; }

		[Outlet]
		UIKit.UILabel FullName { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FullName != null) {
				FullName.Dispose ();
				FullName = null;
			}

			if (FirstLetter != null) {
				FirstLetter.Dispose ();
				FirstLetter = null;
			}
		}
	}
}
