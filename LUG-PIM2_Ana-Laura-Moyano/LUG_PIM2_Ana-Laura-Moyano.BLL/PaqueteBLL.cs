using LUG_PIM2_Ana_Laura_Moyano.DAL;
using LUG_PIM2_Ana_Laura_Moyano.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace LUG_PIM2_Ana_Laura_Moyano.BLL
{
	public class PaqueteBLL
	{
		private string connectionString;

		public event EventHandler ActualizacionPaquete;

		public PaqueteBLL(string connectionString)
		{
			this.connectionString = connectionString;
		}

		public void CrearPaquete(Paquete nuevoPaquete)
		{
			try
			{
				SqlConnection connection = new SqlConnection(connectionString);
				IDal<Paquete> paqueteDAL = new PaqueteDAL(connection);
				paqueteDAL.Insert(nuevoPaquete);
				ActualizacionPaquete?.Invoke(this, null);
			}
			catch (SqlException)
			{
				throw new Exception("Ha ocurrido un error persistiendo los datos");
			}
			catch (Exception)
			{
				throw new Exception("Ha ocurrido un error agregando el paquete");
			}
		}

		public void ActualizarPaquete(Paquete paquete)
		{
			try
			{
				SqlConnection connection = new SqlConnection(connectionString);
				IDal<Paquete> paqueteDAL = new PaqueteDAL(connection);
				paqueteDAL.Update(paquete);
				ActualizacionPaquete?.Invoke(this, null);
			}
			catch (SqlException)
			{
				throw new Exception("Ha ocurrido un error persistiendo los datos");
			}
			catch (Exception)
			{
				throw new Exception("Ha ocurrido un error actualizando el paquete");
			}
		}

		public void BorrarPaquete(Paquete paquete)
		{
			try
			{
				SqlConnection connection = new SqlConnection(connectionString);
				IDal<Paquete> paqueteDAL = new PaqueteDAL(connection);
				paqueteDAL.Delete(paquete);
				ActualizacionPaquete?.Invoke(this, null);
			}
			catch (SqlException ex)
			{
				if (ex.Number == 547)
					throw new Exception("Este registro esta en uso. Borre las referencias que lo utilizan.");
				throw new Exception("Ha ocurrido un error persistiendo los datos");
			}
			catch (Exception)
			{
				throw new Exception("Ha ocurrido un error borrando el paquete");
			}
		}

		public IEnumerable<Paquete> ListarPaquete()
		{
			try
			{
				SqlConnection connection = new SqlConnection(connectionString);
				IDal<Paquete> paqueteDAL = new PaqueteDAL(connection);
				IEnumerable<Paquete> resultado = paqueteDAL.Select();
				return resultado;
			}
			catch
			{
				return null;
			}
		}

		public IEnumerable<PaquetesCanales> ListarCanalesPorPaquetes()
		{
			try
			{
				SqlConnection connection = new SqlConnection(connectionString);
				IDal<PaquetesCanales> paqueteCanalesDAL = new PaquetesCanalesDAL(connection);
				IEnumerable<PaquetesCanales> resultado = paqueteCanalesDAL.Select();
				return resultado;
			}
			catch
			{
				return null;
			}
		}

		public Paquete ObtenerPaqueteMenosSolicitado()
		{
			try
			{
				SqlConnection connection = new SqlConnection(connectionString);
				IDal<Cliente> clienteDAL = new ClienteDAL(connection);
				IDal<Paquete> paqueteDAL = new PaqueteDAL(connection);

				ICollection<Cliente> paquetes = clienteDAL
					.Select()
					.Where(c => c.Paquete_id != null)
					.ToList();

				if (paquetes.Count == 0)
					throw new InvalidOperationException("No hay paquetes disponibles.");

				int? paquete_ID = paquetes.GroupBy(c => c.Paquete_id)
					.Select(c => new { Paquete_id = c.Key, Count = c.Count() })
					.OrderBy(c => c.Count)
					.FirstOrDefault()
					.Paquete_id;

				return paqueteDAL.Select().FirstOrDefault(p => p.Id == paquete_ID);
			}
			catch (InvalidOperationException ex)
			{
				throw ex;
			}
			catch (SqlException)
			{
				throw new Exception("Ha ocurrido un error consultando");
			}
			catch (Exception)
			{
				throw new Exception("Error obteniendo el paquete menos solicitado");
			}
		}

		public Paquete ObtenerPaqueteMasSolicitado()
		{
			try
			{
				SqlConnection connection = new SqlConnection(connectionString);
				IDal<Cliente> clienteDAL = new ClienteDAL(connection);
				IDal<Paquete> paqueteDAL = new PaqueteDAL(connection);

				ICollection<Cliente> paquetes = clienteDAL
					.Select()
					.Where(c => c.Paquete_id != null)
					.ToList();

				if (paquetes.Count == 0)
					throw new InvalidOperationException("No hay paquetes disponibles.");

				int? paquete_ID = paquetes.GroupBy(c => c.Paquete_id)
					.Select(c => new { Paquete_id = c.Key, Count = c.Count() })
					.OrderByDescending(c => c.Count)
					.FirstOrDefault()
					.Paquete_id;

				return paqueteDAL.Select().FirstOrDefault(p => p.Id == paquete_ID);
			}
			catch (InvalidOperationException ex)
			{
				throw ex;
			}
			catch (SqlException)
			{
				throw new Exception("Ha ocurrido un error consultando");
			}
			catch (Exception)
			{
				throw new Exception("Error obteniendo el paquete menos solicitado");
			}
		}

		public void AsociarPaqueteCanal(Paquete paquete, Canal canal)
		{
			try
			{
				if (paquete == null || canal == null)
					throw new Exception("Faltan datos");
				SqlConnection connection = new SqlConnection(connectionString);
				IDal<PaquetesCanales> paqueteCanalesDAL = new PaquetesCanalesDAL(connection);
				PaquetesCanales registro = new PaquetesCanales
				{
					Canal_Id = canal.Id,
					Paquete_Id = paquete.Id
				};
				paqueteCanalesDAL.Insert(registro);
			}
			catch (SqlException ex)
			{
				// Errores de violacion de UNIQUE.
				if (ex.Number == 2601 || ex.Number == 2627)
					throw new Exception("La asociacion entre canal y paquete ya existe.");
				throw new Exception("Error de base de datos guardando la referencia.");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void BorrarCanalDePaquete(PaquetesCanales paquetesCanales)
		{
			try
			{
				if (paquetesCanales == null)
					throw new Exception("Faltan datos");
				SqlConnection connection = new SqlConnection(connectionString);
				PaquetesCanalesDAL paquetesCanalesDAL = new PaquetesCanalesDAL(connection);
				paquetesCanalesDAL.Delete(paquetesCanales);
			}
			catch (SqlException)
			{
				throw new Exception("Error de base de datos eliminando la referencia.");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
