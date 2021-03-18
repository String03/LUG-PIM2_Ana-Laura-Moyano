using LUG_PIM2_Ana_Laura_Moyano.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUG_PIM2_Ana_Laura_Moyano.DAL.SqlCommands
{
	public class PaquetesCanalesSqlCommandBuilder : ISqlCommandBuilder<PaquetesCanales>
	{
		public SqlCommand Delete(PaquetesCanales entity)
		{
			var command = new SqlCommand("DELETE FROM PaquetesCanales WHERE Id = @Id");
			command.Parameters.AddWithValue("Id", entity.Id);
			return command;
		}

		public SqlCommand Insert(PaquetesCanales entity)
		{
			var command = new SqlCommand("INSERT INTO [dbo].[PaquetesCanales] ([Canal_Id] ,[Paquete_Id]) VALUES (@Canal_Id, @Paquete_Id)");
			command.Parameters.AddWithValue("Canal_Id", entity.Canal_Id);
			command.Parameters.AddWithValue("Paquete_Id", entity.Paquete_Id);

			return command;
		}

		public SqlCommand Select()
		{
			return new SqlCommand("SELECT * FROM PaquetesCanales");
		}

		public SqlCommand Update(PaquetesCanales entity)
		{
			var command = new SqlCommand("UPDATE [dbo].[PaquetesCanales] SET [Canal_Id] = @Canal_Id, [Paquete_Id] = @Paquete_Id WHERE Id = @Id");
			command.Parameters.AddWithValue("Id", entity.Id);
			command.Parameters.AddWithValue("Canal_Id", entity.Canal_Id);
			command.Parameters.AddWithValue("Paquete_Id", entity.Paquete_Id);

			return command;
		}
	}
}
