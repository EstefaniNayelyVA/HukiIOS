using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Huki.Modelo
{
	public class Perfil
    {
		public int Id { get; set;}
		public DateTime Fecha { get; set;}
		public string Descripción { get; set; }
		public int Goles { get; set;}
        public int Faltas { get; set;}
        public int TarjetaRoja { get; set;}
		public int TarjetaAmarilla { get; set;}
        public int Asistencias { get; set;}
    }
}
