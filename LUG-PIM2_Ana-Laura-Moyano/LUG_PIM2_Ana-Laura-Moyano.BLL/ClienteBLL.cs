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
	public class ClienteBLL
	{
		private string connectionString;

        public event EventHandler ActualizacionCliente;

		public ClienteBLL(string connectionString)
		{
			this.connectionString = connectionString;
		}

		public IEnumerable<Cliente> BuscarClientes()
		{
			try
			{
				SqlConnection connection = new SqlConnection(connectionString);
				IDal<Cliente> clienteDAL = new ClienteDAL(connection);
				return clienteDAL.Select();
			}
			catch (SqlException)
			{
				throw new Exception("Ha ocurrido un error de SQL buscando los clientes");
			}
			catch (Exception)
			{
				throw new Exception("Error listando los clientes");
			}
		}

		public void CrearCliente(Cliente cliente)
		{
			try
			{
				SqlConnection connection = new SqlConnection(connectionString);
				IDal<Cliente> clienteDAL = new ClienteDAL(connection);
				int diferencia = (DateTime.Now - cliente.FechaNacimiento).Days / 365;
				if (diferencia < 18)
					throw new InvalidOperationException("Cliente menor de edad");
				clienteDAL.Insert(cliente);
                ActualizacionCliente?.Invoke(this, null);
			}
			catch (InvalidOperationException ex)
			{
				throw ex;
			}
			catch (SqlException ex)
			{
				// Errores de violacion de UNIQUE.
				if (ex.Number == 2601 || ex.Number == 2627)
					throw new Exception("Ya existe un cliente con este DNI");
				throw new Exception("Ha ocurrido un error pesistiendo los datos del cliente");
			}
			catch (Exception)
			{
				throw new Exception("Error creando al cliente");
			}
		}

		public void ActualizarCliente(Cliente cliente)
		{
			try
			{
				SqlConnection connection = new SqlConnection(connectionString);
				IDal<Cliente> clienteDAL = new ClienteDAL(connection);
				clienteDAL.Update(cliente);
                ActualizacionCliente?.Invoke(this, null);
            }
			catch (InvalidOperationException ex)
			{
				throw ex;
			}
			catch (SqlException)
			{
				throw new Exception("Ha ocurrido un error actualizando el cliente");
			}
			catch (Exception)
			{
				throw new Exception("Error actualizando al cliente");
			}
		}

		public void BorrarCliente(Cliente cliente)
		{
			try
			{
				SqlConnection connection = new SqlConnection(connectionString);
				IDal<Cliente> clienteDAL = new ClienteDAL(connection);
				clienteDAL.Delete(cliente);
                ActualizacionCliente?.Invoke(this, null);
            }
			catch (InvalidOperationException ex)
			{
				throw ex;
			}
			catch (SqlException ex)
			{
				if (ex.Number == 547)
					throw new Exception("Este registro esta en uso. Borre las referencias que lo utilizan.");
				throw new Exception("Ha ocurrido un error borrando el cliente en la base de datos");
			}
			catch (Exception)
			{
				throw new Exception("Error borrando al cliente");
			}
		}

	}
}
