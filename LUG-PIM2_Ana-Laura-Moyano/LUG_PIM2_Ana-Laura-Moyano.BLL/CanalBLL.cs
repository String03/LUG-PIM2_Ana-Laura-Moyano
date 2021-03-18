using LUG_PIM2_Ana_Laura_Moyano.DAL;
using LUG_PIM2_Ana_Laura_Moyano.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUG_PIM2_Ana_Laura_Moyano.BLL
{
    public class CanalBLL
    {

        private string connectionString;

        public event EventHandler ActualizacionCanal;

        public CanalBLL(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public IEnumerable<Canal> BuscarCanales()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                IDal<Canal> canalDAL = new CanalDAL(connection);
                return canalDAL.Select();
            }
            catch (SqlException)
            {
                throw new Exception("Ha ocurrido un error de SQL buscando los canales");
            }
            catch (Exception)
            {
                throw new Exception("Error listando los canales");
            }
        }

        public void CrearCanal(Canal canal)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                IDal<Canal> canalDAL = new CanalDAL(connection);
               
                canalDAL.Insert(canal);
                ActualizacionCanal?.Invoke(this, null);
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (SqlException)
            {
                throw new Exception("Ha ocurrido un error pesistiendo los datos del canal");
            }
            catch (Exception)
            {
                throw new Exception("Error creando al canal");
            }
        }

        public void ActualizarCanal(Canal canal)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                IDal<Canal> canalDAL = new CanalDAL(connection);
                canalDAL.Update(canal);
                ActualizacionCanal?.Invoke(this, null);
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (SqlException)
            {
                throw new Exception("Ha ocurrido un error actualizando el canal");
            }
            catch (Exception)
            {
                throw new Exception("Error actualizando al canal");
            }
        }

        public void BorrarCanal(Canal canal)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                IDal<Canal> canalDAL = new CanalDAL(connection);
                canalDAL.Delete(canal);
                ActualizacionCanal?.Invoke(this, null);
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (SqlException ex)
            {
				if (ex.Number == 547)
					throw new Exception("Este registro esta en uso. Borre las referencias que lo utilizan.");
                throw new Exception("Ha ocurrido un error borrando el canal en la base de datos");
            }
            catch (Exception)
            {
                throw new Exception("Error borrando al canal");
            }
        }
    } 
}
