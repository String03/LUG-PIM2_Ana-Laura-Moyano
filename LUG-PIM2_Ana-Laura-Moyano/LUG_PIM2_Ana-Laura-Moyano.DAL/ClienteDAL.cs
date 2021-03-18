using LUG_PIM2_Ana_Laura_Moyano.DAL.SqlCommands;
using LUG_PIM2_Ana_Laura_Moyano.Modelos;
using System;
using System.Data.SqlClient;

namespace LUG_PIM2_Ana_Laura_Moyano.DAL
{
	public class ClienteDAL : AbstractDal<Cliente>
	{
		public ClienteDAL(SqlTransaction transaction) : base(transaction, new ClienteSqlCommandBuilder())
		{
		}

		public ClienteDAL(SqlConnection connection) : base(connection, new ClienteSqlCommandBuilder())
		{
		}

		protected override Cliente TransFormarReaderPuntual(SqlDataReader reader)
		{
			return new Cliente
			{
				Id = (int)reader["Id"],
				Nombre = (string)reader["Nombre"],
				Apellido = (string)reader["Apellido"],
				Dni = (string)reader["Dni"],
				FechaNacimiento = (DateTime)reader["FechaNacimiento"],
				FormaPago = reader["FormaPago"].ToString(),
				Paquete_id = reader["Paquete_Id"] == DBNull.Value ? null : (int?)reader["Paquete_Id"]
			};
		}
	}
}
