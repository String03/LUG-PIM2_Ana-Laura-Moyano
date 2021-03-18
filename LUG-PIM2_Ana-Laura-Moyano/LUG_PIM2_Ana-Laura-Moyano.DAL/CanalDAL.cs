using LUG_PIM2_Ana_Laura_Moyano.DAL.SqlCommands;
using LUG_PIM2_Ana_Laura_Moyano.Modelos;
using System.Data.SqlClient;

namespace LUG_PIM2_Ana_Laura_Moyano.DAL
{
	public class CanalDAL : AbstractDal<Canal>
	{
		public CanalDAL(SqlTransaction transaction) : base(transaction, new CanalSqlCommandBuilder())
		{
		}

		public CanalDAL(SqlConnection connection) : base(connection, new CanalSqlCommandBuilder())
		{
		}

		protected override Canal TransFormarReaderPuntual(SqlDataReader reader)
		{
			return new Canal
			{
				Id = (int)reader["Id"],
				Nombre = (string)reader["Nombre"],
				Codigo = (string)reader["Codigo"]
			};
		}
	}
}
