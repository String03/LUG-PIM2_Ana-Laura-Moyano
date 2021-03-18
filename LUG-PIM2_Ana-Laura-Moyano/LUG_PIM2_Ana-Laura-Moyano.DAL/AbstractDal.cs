using LUG_PIM2_Ana_Laura_Moyano.DAL.SqlCommands;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LUG_PIM2_Ana_Laura_Moyano.DAL
{
	public abstract class AbstractDal<T> : IDal<T>
	{
		private SqlConnection connection;
		private SqlTransaction transaction;
		protected ISqlCommandBuilder<T> commandBuilder;

		public AbstractDal(SqlTransaction transaction, ISqlCommandBuilder<T> commandBuilder)
		{
			this.transaction = transaction;
			this.connection = transaction.Connection;
			this.commandBuilder = commandBuilder;
		}

		public AbstractDal(SqlConnection connection, ISqlCommandBuilder<T> commandBuilder)
		{
			this.connection = connection;
			this.transaction = null;
			this.commandBuilder = commandBuilder;
		}

		public void Delete(T entidad)
		{
			var command = commandBuilder.Delete(entidad);
			OperateCommand(command);
		}

		private void OperateCommand(SqlCommand command)
		{
			// Corrige los NULLs de los parametros.
			foreach (SqlParameter parametro in command.Parameters)
			{
				if (parametro.Value == null)
					parametro.Value = DBNull.Value;
			}

			if (transaction != null)
				command.Transaction = transaction;

			command.Connection = connection;

			if (connection.State == ConnectionState.Closed)
				connection.Open();

			command.ExecuteNonQuery();

			if(transaction == null)
				connection.Close();

			if (transaction == null)
				Dispose();
		}

		public void Dispose()
		{
			this.connection.Dispose();
		}

		public void Insert(T entidad)
		{
			var command = commandBuilder.Insert(entidad);
			OperateCommand(command);
		}

		public IEnumerable<T> Select()
		{
			var command = commandBuilder.Select();
			command.Connection = connection;

			if (connection.State == ConnectionState.Closed)
				connection.Open();

			var reader = command.ExecuteReader();
			var resultado = TransformarReader(reader);
			connection.Close();
			return resultado;
		}

		protected virtual IEnumerable<T> TransformarReader(SqlDataReader reader)
		{
			List<T> resultado = new List<T>();
			if (reader == null)
				return resultado;

			if (reader.HasRows)
			{
				while (reader.Read())
				{
					resultado.Add(TransFormarReaderPuntual(reader));
				}
			}

			return resultado;
		}

		protected abstract T TransFormarReaderPuntual(SqlDataReader reader);

		public void Update(T entidad)
		{
			var command = commandBuilder.Update(entidad);
			OperateCommand(command);
		}
	}
}
