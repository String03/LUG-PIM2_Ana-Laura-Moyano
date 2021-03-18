using LUG_PIM2_Ana_Laura_Moyano.DAL.SqlCommands;
using LUG_PIM2_Ana_Laura_Moyano.Modelos;
using System;
using System.Data.SqlClient;

namespace LUG_PIM2_Ana_Laura_Moyano.DAL
{
	public class PaquetesCanalesDAL : AbstractDal<PaquetesCanales>
	{
		public PaquetesCanalesDAL(SqlTransaction transaction) : base(transaction, new PaquetesCanalesSqlCommandBuilder())
		{
		}

		public PaquetesCanalesDAL(SqlConnection connection) : base(connection, new PaquetesCanalesSqlCommandBuilder())
		{
		}

		protected override PaquetesCanales TransFormarReaderPuntual(SqlDataReader reader)
		{
			return new PaquetesCanales
			{
				Id = (int)reader["Id"],
				Canal_Id = (int)reader["Canal_Id"],
				Paquete_Id = (int)reader["Paquete_Id"]
			};
		}
	}
}
