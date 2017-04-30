using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Foundation;
using Huki.Modelo;
using SQLite;
using UIKit;

namespace Huki
{
	public partial class Entrenadores : UIViewController
	{
		public List<Entrenador> ListaEntrenadores;
		public Entrenadores(IntPtr hanlder) : base(hanlder)
		{
		}
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			ListaEntrenadores = new List<Entrenador>();
			this.generarDatosSQLite();//esto se cambia por obtenerDatosRestSQlite();
			llenarTabla();
		}
		public async void generarDatosSQLite()
		{
			var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			path = Path.Combine(path, "HukiBD.db3");
			var conn = new SQLiteConnection(path);
			try
			{
				conn.CreateTable<Entrenador>();//crea una tabla con la estructura de la clase empledo.
				conn.Insert(new Entrenador()
				{
					Deporte = "Futbol Soccer",
					Nombre = "Javier Perez",
					FotoURL = "Foto1.jpg"
					//,FotoURL = "foto1.jpg"
				});
				WebClient clienteWeb = new WebClient();
				byte[] datosImagen = await clienteWeb.DownloadDataTaskAsync("http://dreamicus.com/data/apple/apple-01.jpg");//metodo que descarga una foto por medio de la ruta que se pasa por el parametro y la retorna como tipo de arreglo de bytes
				string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Personal);//guarda en un folder de la app la foto en el sistema de archivos local de la app.
				string archivo = "Foto1.jpg";//nombre que se le va a poner a la foto
				string rutaArchivo = Path.Combine(ruta, archivo);//se guarda como texto la ruta donde se va a guardar el archivo y el nombre del archivo.
				File.WriteAllBytes(rutaArchivo, datosImagen);//se estable lo anterior y se pasa la imagen como arreglo de bytes.

			}
			catch (Exception ex)
			{
				MessageBox("Error: ", ex.Message);
			}
		}
		public void llenarTabla()
		{
			ListaEntrenadores.Clear();
			var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			path = Path.Combine(path, "HukiBD.db3");
			var conn = new SQLiteConnection(path);
			try
			{
				var elementos = from s in conn.Table<Entrenador>() select s;//query de bd
				foreach (var fila in elementos)
				{
					ListaEntrenadores.Add(new Entrenador
					{
						Nombre = fila.Nombre,
						Deporte = fila.Deporte
						//,FotoURL = fila.FotoURL//Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), fila.FotoURL)
					});
				}
			}
			catch (Exception ex)
			{
				MessageBox("Error: ", ex.Message);
			}
			TablaEntrenadores.Source = null;
			TablaEntrenadores.Source = new OrigenTabla(ListaEntrenadores, this);
			TablaEntrenadores.ReloadData();
		}
		public void MessageBox(string titulo, string mensaje)
		{
			using (var alerta = new UIAlertView())
			{
				alerta.Title = titulo;
				alerta.Message = mensaje;
				alerta.AddButton("Aceptar");
				alerta.Show();
			}
		}
	}
}

