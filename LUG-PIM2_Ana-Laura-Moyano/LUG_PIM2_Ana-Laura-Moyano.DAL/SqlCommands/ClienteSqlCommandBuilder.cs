using LUG_PIM2_Ana_Laura_Moyano.Modelos;
using System.Data.SqlClient;

namespace LUG_PIM2_Ana_Laura_Moyano.DAL.SqlCommands
{
	public class ClienteSqlCommandBuilder : ISqlCommandBuilder<Cliente>
	{
		public SqlCommand Delete(Cliente entity)
		{
			var command = new SqlCommand("DELETE FROM Clientes WHERE Id = @Id");
			command.Parameters.AddWithValue("Id", entity.Id);
			return command;
		}

		public SqlCommand Insert(Cliente entity)
		{
			var command = new SqlCommand("INSERT INTO [dbo].[Clientes] ([Nombre] ,[Apellido] ,[Dni] ,[FechaNacimiento] ,[Paquete_Id] ,[FormaPago]) VALUES (@Nombre, @Apellido, @Dni, @FechaNacimiento, @Paquete_Id, @FormaPago)");
			command.Parameters.AddWithValue("Nombre", entity.Nombre);
			command.Parameters.AddWithValue("Apellido", entity.Apellido);
			command.Parameters.AddWithValue("Dni", entity.Dni);
			command.Parameters.AddWithValue("FechaNacimiento", entity.FechaNacimiento);
			command.Parameters.AddWithValue("Paquete_Id", entity.Paquete_id);
			command.Parameters.AddWithValue("FormaPago", entity.FormaPago);
			return command;
		}

		public SqlCommand Select()
		{
			return new SqlCommand("SELECT * FROM Clientes");
		}

		public SqlCommand Update(Cliente entity)
		{
			var command = new SqlCommand("UPDATE [dbo].[Clientes] SET [Nombre] = @Nombre, [Apellido] = @Apellido, [Dni] = @Dni, [FechaNacimiento] = @FechaNacimiento, [Paquete_Id] = @Paquete_Id, [FormaPago] = @FormaPago WHERE Id = @Id ");
			command.Parameters.AddWithValue("Id", entity.Id);
			command.Parameters.AddWithValue("Nombre", entity.Nombre);
			command.Parameters.AddWithValue("Apellido", entity.Apellido);
			command.Parameters.AddWithValue("Dni", entity.Dni);
			command.Parameters.AddWithValue("FechaNacimiento", entity.FechaNacimiento);
			command.Parameters.AddWithValue("Paquete_Id", entity.Paquete_id);
			command.Parameters.AddWithValue("FormaPago", entity.FormaPago);
			return command;
		}
	}
}
