using System;
using System.Collections.Generic;
using System.IO;
using Huki.Modelo;
using UIKit;

namespace Huki
{
	public partial class Actividad : UITableViewController
	{
		public List<Logro> listalogros;
		public List<Perfil> listaPerfil;
		public Actividad(IntPtr handler) : base(handler)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			// Take action based on the number of players selected
			CargarEntrenamientos();
			CategoriaActividad.ValueChanged += (sender, e) =>
			{
				var selectedSegmentId = (sender as UISegmentedControl).SelectedSegment;
				CambioCategoria();
			};
		}
		public void CambioCategoria() 
		{ 
			switch (CategoriaActividad.SelectedSegment)
			{
				case 0:
					CargarEntrenamientos();
		        	break;
				case 1:
					CargarLogros();
		        	break;
		 	}
		}

		public void CargarEntrenamientos() 
		{
			//logica de base de datos :c
			//hardcodeado :v
			listaPerfil = new List<Perfil>()
			{
				new Perfil{ Descripción = "Entrenamiento", Fecha = new DateTime(2017,04,1), Asistencias = 1 , Faltas = 10 , Goles = 1, TarjetaRoja = 1, TarjetaAmarilla = 1},
				new Perfil{ Descripción = "Entrenamiento", Fecha = new DateTime(2017,03,21), Asistencias = 0, Faltas = 1 , Goles = 4, TarjetaRoja = 0, TarjetaAmarilla = 1},
				new Perfil{ Descripción = "Partido", Fecha = new DateTime(2017,03,10), Asistencias = 0, Faltas = 2 , Goles = 0, TarjetaRoja = 0, TarjetaAmarilla = 0},
				new Perfil{ Descripción = "Cascarita Universitaria", Fecha = new DateTime(2016,11,20), Asistencias = 3, Faltas = 0 , Goles = 0, TarjetaRoja = 0, TarjetaAmarilla = 0},
				new Perfil{ Descripción = "Entrenamiento", Fecha = new DateTime(2016,02,1), Asistencias = 1, Faltas = 0 , Goles = 0, TarjetaRoja = 0, TarjetaAmarilla = 2}
			};
			TablaActividad.Source = null;
			TablaActividad.Source = new TablaActividad(listaPerfil, this);
			TablaActividad.ReloadData();
		}
		public void CargarLogros(){
			//Logica de base de datos :c

			//hardcodeado por mientras :v
			listalogros = new List<Logro>()
			{
				new Logro{ Descripción = "Tu primer Gol de media Cancha", Tipo = "Goliza", Foto = ("Imagenes/trofeo.png")},
				new Logro{ Descripción = "5 Goles Seguidos", Tipo = "Goliza", Foto = ("Imagenes/trofeo.png")},
				new Logro{ Descripción = "5 entrenamientos en una semana", Tipo = "Consistencia", Foto = ("Imagenes/trofeo.png")},
				new Logro{ Descripción = "3 entrenamientos en una semana", Tipo = "Consistencia", Foto = ("Imagenes/trofeo.png")}
			};
			TablaActividad.Source = null;
			TablaActividad.Source = new TablaLogros(listalogros, this);
			TablaActividad.ReloadData();
		}
		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

