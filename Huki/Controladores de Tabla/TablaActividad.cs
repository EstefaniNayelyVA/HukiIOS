using System;
using System.Collections.Generic;
using System.Drawing;
using Huki.Modelo;
using UIKit;

namespace Huki
{
public class TablaActividad : UITableViewSource
{
		//propiedades:
		public List<Perfil> ElementosTabla;
		public string IDCelda = "Celda";
		public UIViewController Controlador;

		//sobrecarga:
		public TablaActividad(List<Perfil> elementos, UIViewController controlador)
		{
			ElementosTabla = elementos;
			Controlador = controlador;
		}
		public TablaActividad()
		{
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
			string elemento = ElementosTabla[indexPath.Row].Descripción;
			string detalle = ElementosTabla[indexPath.Row].Fecha.ToLongDateString();
		if (celda == null)
		{
			celda = new UITableViewCell(UITableViewCellStyle.Subtitle, IDCelda);
		}
		celda.TextLabel.Text = elemento;
		celda.DetailTextLabel.Text = detalle;
		//celda.ImageView.Image = ResizeImage((UIImage.FromBundle(ElementosTabla[indexPath.Row].Foto)), 120, 120);//cambia el tamaño de las imagenes para que se ajusten 
		//celda.ImageView.Image = UIImage.FromFile("Foto1.jpg"); //esto es para poder 
		return celda;
	}
	public override nint RowsInSection(UITableView tableview, nint section)
	{
		return ElementosTabla.Count;//cuenta los elementos de la lista
	}

		public static implicit operator UITableView(TablaActividad v)
		{
			throw new NotImplementedException();
		}
	}
}
