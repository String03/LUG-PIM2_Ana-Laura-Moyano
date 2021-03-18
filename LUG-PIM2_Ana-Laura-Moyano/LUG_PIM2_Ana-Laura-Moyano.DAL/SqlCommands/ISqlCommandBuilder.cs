using System.Data.SqlClient;

namespace LUG_PIM2_Ana_Laura_Moyano.DAL.SqlCommands
{
	public interface ISqlCommandBuilder<T>
	{
		SqlCommand Select();
		SqlCommand Insert(T entity);
		SqlCommand Update(T entity);
		SqlCommand Delete(T entity);
	}
}
