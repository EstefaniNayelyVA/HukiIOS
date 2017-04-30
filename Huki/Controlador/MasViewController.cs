using System;


using UIKit;

namespace Huki
{
	public partial class MasViewController : UITableViewController
	{
		public MasViewController(IntPtr handler) : base(handler)
		{
		}
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			nfloat tamaño = (imagenPerfil.Frame.Size.Width) / 2;
			imagenPerfil.Layer.CornerRadius = tamaño;
			imagenPerfil.ClipsToBounds = true;
			imagenPerfil.Layer.BorderWidth = 3.0f;
			CoreGraphics.CGColor color = new CoreGraphics.CGColor(0.2f,0.3f,1.0f,1.0f);
			imagenPerfil.Layer.BorderColor = color;
			imagenPerfil.Image = UIImage.FromBundle("Imagenes/Ivan.jpg");
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

	}
}

