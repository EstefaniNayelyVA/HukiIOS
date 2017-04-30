using System;

using UIKit;

namespace University
{
	public partial class TableViewController : UITableViewController
	{
		public TableViewController(IntPtr handler) : base(handler)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			nfloat tamaño = (img1.Frame.Size.Width) / 2;
			img1.Layer.CornerRadius = tamaño;
			img1.ClipsToBounds = true;
			nfloat tamaño2 = (img2.Frame.Size.Width) / 2;
			img2.Layer.CornerRadius = tamaño2;
			img2.ClipsToBounds = true;
			nfloat tamaño3 = (img3.Frame.Size.Width) / 2;
			img3.Layer.CornerRadius = tamaño3;
			img3.ClipsToBounds = true;

			//img1.Layer.BorderWidth = 3.0f;
			//CoreGraphics.CGColor color = new CoreGraphics.CGColor(0.0f, 0.3f, 1.0f, 1.0f);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

