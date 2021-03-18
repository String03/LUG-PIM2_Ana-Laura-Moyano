using LUG_PIM2_Ana_Laura_Moyano.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUG_PIM2_Ana_Laura_Moyano.DAL.SqlCommands
{
	public class PaqueteSqlCommandBuilder : ISqlCommandBuilder<Paquete>
	{
		public SqlCommand Delete(Paquete entity)
		{
			var command = new SqlCommand("DELETE FROM Paquetes WHERE Id = @Id");
			command.Parameters.AddWithValue("Id", entity.Id);
			return command;
		}

		public SqlCommand Insert(Paquete entity)
		{
			var command =  new SqlCommand("INSERT INTO Paquetes(Descripcion, Costo) VALUES (@Descripcion, @Costo)");
			command.Parameters.AddWithValue("Descripcion", entity.Descripcion);
			command.Parameters.AddWithValue("Costo", entity.Costo);
			return command;
		}

		public SqlCommand Select()
		{
			return new SqlCommand("SELECT * FROM Paquetes");
		}

		public SqlCommand Update(Paquete entity)
		{
			var command =  new SqlCommand("UPDATE Paquetes SET Descripcion = @Descripcion, Costo = @Costo WHERE Id = @Id");
			command.Parameters.AddWithValue("Id", entity.Id);
			command.Parameters.AddWithValue("Descripcion", entity.Descripcion);
			command.Parameters.AddWithValue("Costo", entity.Costo);
			return command;
		}
	}
}
