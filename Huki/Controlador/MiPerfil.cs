using System;
using Foundation;
using UIKit;

namespace Huki
{
	public partial class MiPerfil : UITableViewController
	{
		public MiPerfil(IntPtr hanlder) : base(hanlder)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			Imagen.Image = UIImage.FromBundle("Imagenes/Ivan.jpg");
		}
		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			
		}
		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

