using LUG_PIM2_Ana_Laura_Moyano.Modelos;
using System.Data.SqlClient;

namespace LUG_PIM2_Ana_Laura_Moyano.DAL.SqlCommands
{
	public class OrdenSqlCommandBuilder : ISqlCommandBuilder<Orden>
	{
		public SqlCommand Delete(Orden entity)
		{
			var command = new SqlCommand("DELETE FROM Ordenes WHERE Id = @Id");
			command.Parameters.AddWithValue("Id", entity.Id);
			return command;
		}

		public SqlCommand Insert(Orden entity)
		{
			var command = new SqlCommand("INSERT INTO [dbo].[Ordenes] ([Cliente_Id] ,[Paquete_Id] ,[MontoPagado] ,[FechaPago] ,[FormaPago]) VALUES (@Cliente_Id, @Paquete_Id, @MontoPagado, @FechaPago, @FormaPago)");
			command.Parameters.AddWithValue("Cliente_Id", entity.Cliente_Id);
			command.Parameters.AddWithValue("Paquete_Id", entity.Paquete_Id);
			command.Parameters.AddWithValue("MontoPagado", entity.MontoPagado);
			command.Parameters.AddWithValue("FechaPago", entity.FechaPago);
			command.Parameters.AddWithValue("FormaPago", entity.FormaPago);
			return command;
		}

		public SqlCommand Select()
		{
			return new SqlCommand("SELECT * FROM Ordenes");
		}

		public SqlCommand Update(Orden entity)
		{
			var command = new SqlCommand("UPDATE [dbo].[Ordenes] SET [Cliente_Id] = @Cliente_Id, [Paquete_Id] = @Paquete_Id, [MontoPagado] = @MontoPagado, [FechaPago] = @FechaPago, [FormaPago] = @FormaPago WHERE Id = @Id ");
			command.Parameters.AddWithValue("Id", entity.Id);
			command.Parameters.AddWithValue("Cliente_Id", entity.Cliente_Id);
			command.Parameters.AddWithValue("Paquete_Id", entity.Paquete_Id);
			command.Parameters.AddWithValue("MontoPagado", entity.MontoPagado);
			command.Parameters.AddWithValue("FechaPago", entity.FechaPago);
			command.Parameters.AddWithValue("FormaPago", entity.FormaPago);
			return command;
		}
	}
}
