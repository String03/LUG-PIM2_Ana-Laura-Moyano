using LUG_PIM2_Ana_Laura_Moyano.DAL.SqlCommands;
using LUG_PIM2_Ana_Laura_Moyano.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUG_PIM2_Ana_Laura_Moyano.DAL
{
	public class OrdenDAL : AbstractDal<Orden>
	{
		public OrdenDAL(SqlTransaction transaction) : base(transaction, new OrdenSqlCommandBuilder())
		{
		}

		public OrdenDAL(SqlConnection connection) : base(connection, new OrdenSqlCommandBuilder())
		{
		}

		protected override Orden TransFormarReaderPuntual(SqlDataReader reader)
		{
			return new Orden
			{
				Id = (int)reader["Id"],
				Cliente_Id = (int)reader["Cliente_Id"],
				FechaPago = (DateTime)reader["FechaPago"],
				FormaPago = (string)reader["FormaPago"],
				MontoPagado = (decimal)reader["MontoPagado"],
				Paquete_Id = (int)reader["Paquete_Id"]
			};
		}
	}
}
