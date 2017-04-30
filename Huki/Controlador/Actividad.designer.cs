// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Huki
{
	[Register ("Actividad")]
	partial class Actividad
	{
		[Outlet]
		UIKit.UISegmentedControl CategoriaActividad { get; set; }

		[Outlet]
		UIKit.UITableView TablaActividad { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CategoriaActividad != null) {
				CategoriaActividad.Dispose ();
				CategoriaActividad = null;
			}

			if (TablaActividad != null) {
				TablaActividad.Dispose ();
				TablaActividad = null;
			}
		}
	}
}
