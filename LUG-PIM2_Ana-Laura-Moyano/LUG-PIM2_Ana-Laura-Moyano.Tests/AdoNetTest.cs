using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using LUG_PIM2_Ana_Laura_Moyano.DAL;
using LUG_PIM2_Ana_Laura_Moyano.Modelos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LUG_PIM2_Ana_Laura_Moyano.Tests
{
	[TestClass]
	public class AdoNetTest
	{
		[TestMethod]
		public void SelectTest()
		{
			string connectionString = ConfigurationManager.ConnectionStrings["CableDB"].ConnectionString;
			PaqueteDAL paqueteDAL = new PaqueteDAL(new SqlConnection(connectionString));
			var paquetes = paqueteDAL.Select();
		}

		[TestMethod]
		public void InsertTest()
		{
			string connectionString = ConfigurationManager.ConnectionStrings["CableDB"].ConnectionString;
			PaqueteDAL paqueteDAL = new PaqueteDAL(new SqlConnection(connectionString));
			Paquete paquete = new Paquete
			{
				Descripcion = "Prueba",
				Costo = 444.00M
			};
			paqueteDAL.Insert(paquete);
		}

		[TestMethod]
		public void DeleteTest()
		{
			string connectionString = ConfigurationManager.ConnectionStrings["CableDB"].ConnectionString;
			PaqueteDAL paqueteDAL = new PaqueteDAL(new SqlConnection(connectionString));
			paqueteDAL.Delete(paqueteDAL.Select().FirstOrDefault());
		}

		[TestMethod]
		public void UpdateTest()
		{
			string connectionString = ConfigurationManager.ConnectionStrings["CableDB"].ConnectionString;
			PaqueteDAL paqueteDAL = new PaqueteDAL(new SqlConnection(connectionString));
			var primero = paqueteDAL.Select().FirstOrDefault();
			primero.Costo = 666;
			paqueteDAL.Update(primero);
		}
	}
}
