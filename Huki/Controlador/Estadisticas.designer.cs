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
	[Register ("Estadisticas")]
	partial class Estadisticas
	{
		[Outlet]
		UIKit.UINavigationItem Categorias { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Categorias != null) {
				Categorias.Dispose ();
				Categorias = null;
			}
		}
	}
}
