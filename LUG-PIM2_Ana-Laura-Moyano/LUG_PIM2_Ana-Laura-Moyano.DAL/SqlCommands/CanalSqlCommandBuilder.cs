using LUG_PIM2_Ana_Laura_Moyano.Modelos;
using System.Data.SqlClient;

namespace LUG_PIM2_Ana_Laura_Moyano.DAL.SqlCommands
{
	public class CanalSqlCommandBuilder : ISqlCommandBuilder<Canal>
	{
		public SqlCommand Delete(Canal entity)
		{
			var command = new SqlCommand("DELETE FROM Canales WHERE Id = @Id");
			command.Parameters.AddWithValue("Id", entity.Id);
			return command;
		}

		public SqlCommand Insert(Canal entity)
		{
			var command = new SqlCommand("INSERT INTO [dbo].[Canales] ([Codigo] ,[Nombre]) VALUES ( @Codigo, @Nombre)");
			command.Parameters.AddWithValue("Codigo", entity.Codigo);
			command.Parameters.AddWithValue("Nombre", entity.Nombre);
			return command;
		}

		public SqlCommand Select()
		{
			return new SqlCommand("SELECT * FROM Canales");
		}

		public SqlCommand Update(Canal entity)
		{
			var command = new SqlCommand("UPDATE [dbo].[Canales] SET [Codigo] = @Codigo, [Nombre] = @Nombre WHERE Id = @Id ");
			command.Parameters.AddWithValue("Id", entity.Id);
			command.Parameters.AddWithValue("Codigo", entity.Codigo);
			command.Parameters.AddWithValue("Nombre", entity.Nombre);
			return command;
		}
	}
}
