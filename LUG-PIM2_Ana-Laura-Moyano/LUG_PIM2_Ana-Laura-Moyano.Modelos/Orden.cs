using System;

namespace LUG_PIM2_Ana_Laura_Moyano.Modelos
{
	public class Orden
	{
		public int Id { get; set; }
		public int Cliente_Id { get; set; }
		public int Paquete_Id { get; set; }
		public decimal MontoPagado { get; set; }
		public DateTime FechaPago { get; set; }
		public string FormaPago { get; set; }
	}
}
