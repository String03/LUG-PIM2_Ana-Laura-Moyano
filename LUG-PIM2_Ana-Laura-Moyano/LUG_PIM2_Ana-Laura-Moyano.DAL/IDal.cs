using System;
using System.Collections.Generic;

namespace LUG_PIM2_Ana_Laura_Moyano.DAL
{
	/// <summary>
	/// Interfaz DAL para acceder a las entidades en la base de datos.
	/// </summary>
	/// <typeparam name="T">Generic para el tipo de la clase</typeparam>
	public interface IDal<T> : IDisposable
	{
		IEnumerable<T> Select();

		void Insert(T entidad);

		void Delete(T entidad);

		void Update(T entidad);
	}
}
