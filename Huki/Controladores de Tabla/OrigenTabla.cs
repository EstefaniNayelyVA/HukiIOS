using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using Foundation;
using Huki.Modelo;
using UIKit;

namespace Huki
{
	public class OrigenTabla : UITableViewSource
	{
		//propiedades:
		public string Nombre;
		public string ImagenSel;
		public List<Entrenador> ElementosTabla;
		public string IDCelda = "Celda";
		public UIViewController Controlador;

		//sobrecarga:
		public OrigenTabla(List<Entrenador> elementos, UIViewController controlador)
		{
			ElementosTabla = elementos;
			Controlador = controlador;
		}

		//metodos:
		public UIImage ResizeImage(UIImage sourceImage, float width, float height)
		{ //ajustar el tamaño de las imagenes para que todas se vean genericas
			UIGraphics.BeginImageContext(new SizeF(width, height));
			sourceImage.Draw(new RectangleF(0, 0, width, height));
			var resultImage = UIGraphics.GetImageFromCurrentImageContext();
			UIGraphics.EndImageContext();
			return resultImage;
		}
		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var celda = tableView.DequeueReusableCell(IDCelda);
			string elemento = ElementosTabla[indexPath.Row].Nombre;
			string detalle = ElementosTabla[indexPath.Row].Deporte;
			if (celda == null)
			{
				celda = new UITableViewCell(UITableViewCellStyle.Subtitle, IDCelda);
			}
			celda.TextLabel.Text = elemento;
			celda.DetailTextLabel.Text = detalle;
			//celda.ImageView.Image = ResizeImage((UIImage.FromBundle(ElementosTabla[indexPath.Row].FotoURL)), 80, 80);//cambia el tamaño de las imagenes para que se ajusten 
			celda.ImageView.Image = UIImage.FromFile("Foto1.jpg"); //esto es para poder 
			return celda;
		}
		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return ElementosTabla.Count;//cuenta los elementos de la lista
		}
		public async Task<UIImage> DescargarImagen(string url)
		{
			WebClient client = new WebClient();
			byte[] imageArray = await client.DownloadDataTaskAsync(url);
			var data = NSData.FromArray(imageArray);
			var uiimage = UIImage.LoadFromData(data);
			return uiimage;
		}
	}
}
