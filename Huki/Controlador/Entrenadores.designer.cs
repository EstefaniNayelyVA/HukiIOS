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
	[Register ("Entrenadores")]
	partial class Entrenadores
	{
		[Outlet]
		UIKit.UITableView TablaEntrenadores { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TablaEntrenadores != null) {
				TablaEntrenadores.Dispose ();
				TablaEntrenadores = null;
			}
		}
	}
}
