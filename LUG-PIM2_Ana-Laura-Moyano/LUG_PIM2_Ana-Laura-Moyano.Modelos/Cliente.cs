using System;

namespace LUG_PIM2_Ana_Laura_Moyano.Modelos
{
	public class Cliente
	{
		public Cliente()
		{
			FechaNacimiento = DateTime.Now;
		}

		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public string Dni { get; set; }
		public DateTime FechaNacimiento { get; set; }
		public int? Paquete_id { get; set; }
		public string FormaPago { get; set; }
	}
}
