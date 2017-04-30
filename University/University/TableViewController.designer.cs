// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace University
{
	[Register ("TableViewController")]
	partial class TableViewController
	{
		[Outlet]
		UIKit.UIImageView img1 { get; set; }

		[Outlet]
		UIKit.UIImageView img2 { get; set; }

		[Outlet]
		UIKit.UIImageView img3 { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (img1 != null) {
				img1.Dispose ();
				img1 = null;
			}

			if (img2 != null) {
				img2.Dispose ();
				img2 = null;
			}

			if (img3 != null) {
				img3.Dispose ();
				img3 = null;
			}
		}
	}
}
