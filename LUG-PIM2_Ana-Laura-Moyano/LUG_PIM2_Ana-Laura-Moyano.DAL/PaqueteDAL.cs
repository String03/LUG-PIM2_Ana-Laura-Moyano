using LUG_PIM2_Ana_Laura_Moyano.DAL.SqlCommands;
using LUG_PIM2_Ana_Laura_Moyano.Modelos;
using System.Data.SqlClient;

namespace LUG_PIM2_Ana_Laura_Moyano.DAL
{
	public class PaqueteDAL : AbstractDal<Paquete>
	{
		public PaqueteDAL(SqlTransaction transaction) : base(transaction, new PaqueteSqlCommandBuilder())
		{
		}

		public PaqueteDAL(SqlConnection connection) : base(connection, new PaqueteSqlCommandBuilder())
		{
		}

		protected override Paquete TransFormarReaderPuntual(SqlDataReader reader)
		{
			return new Paquete
			{
				Id = (int)reader["Id"],
				Costo = (decimal)reader["Costo"],
				Descripcion = (string)reader["Descripcion"]
			};
		}
	}
}
