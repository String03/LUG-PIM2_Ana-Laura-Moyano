using LUG_PIM2_Ana_Laura_Moyano.DAL;
using LUG_PIM2_Ana_Laura_Moyano.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUG_PIM2_Ana_Laura_Moyano.BLL
{
	public class OrdenesBLL
	{
		private string connectionString;

		public OrdenesBLL(string connectionString)
		{
			this.connectionString = connectionString;
		}

		public void CrearNuevaOrden(Cliente cliente, Paquete paquete, FormasDePago formasDePago)
		{
			try
			{
				if (paquete.Costo <= 0)
					throw new Exception("El costo debe de ser mayor que 0");

				SqlConnection connection = new SqlConnection(connectionString);
				connection.Open();
				SqlTransaction transaction = connection.BeginTransaction();
				try
				{
					OrdenDAL ordenDAL = new OrdenDAL(transaction);

					Orden orden = new Orden
					{
						Cliente_Id = cliente.Id,
						Paquete_Id = paquete.Id,
						FormaPago = formasDePago.ToString(),
						FechaPago = DateTime.Now,
						MontoPagado = CostoPaqueteReal(paquete.Costo, formasDePago)
					};

					ordenDAL.Insert(orden);

					ClienteDAL clienteDAL = new ClienteDAL(transaction);

					cliente.FormaPago = formasDePago.ToString();
					cliente.Paquete_id = paquete.Id;
					clienteDAL.Update(cliente);

					transaction.Commit();
				}
				catch(Exception ex)
				{
					transaction.Rollback();
					throw ex;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private decimal CostoPaqueteReal(decimal costo, FormasDePago formasDePago)
		{
			switch (formasDePago)
			{
				case FormasDePago.DebitoAutomatico:
					return costo * 0.7M;
				case FormasDePago.TarjetaCredito:
					return costo * 0.8M;
				default:
					return costo;
			}
		}

		public object ListarOrdenes()
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			OrdenDAL ordenDAL = new OrdenDAL(sqlConnection);
			return ordenDAL.Select();
		}

		public void EliminarOrden(Orden orden)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(connectionString);
				OrdenDAL ordenDAL = new OrdenDAL(sqlConnection);
				ordenDAL.Delete(orden);
			}
			catch (SqlException)
			{
				throw new Exception("Ha ocurrido un error de SQL al eliminar esta orden.");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
