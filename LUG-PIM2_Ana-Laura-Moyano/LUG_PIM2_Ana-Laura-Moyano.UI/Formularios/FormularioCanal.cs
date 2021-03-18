using LUG_PIM2_Ana_Laura_Moyano.BLL;
using LUG_PIM2_Ana_Laura_Moyano.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUG_PIM2_Ana_Laura_Moyano.UI.Formularios
{
    public partial class FormularioCanal : Form
    {
        private Canal canal;
        private CanalBLL canalBLL;
        
        public FormularioCanal(Canal canal, CanalBLL canalBLL)
        {
            InitializeComponent();

           
            if (canal == null)
            {
                this.canal = new Canal();
            }
            else
            {
                this.canal = canal;
            }
            this.canalBLL = canalBLL;
            LlenarCamposConCanal();


                                 
        }

        private void FormularioCanal_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_canal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LlenarCamposConCanal()
        {
            txt_codigo_canal.Text = canal.Codigo;
            txt_nombre_canal.Text = canal.Nombre;
      
        }

        public void LeerCanal()
        {
            canal.Codigo = txt_codigo_canal.Text;
            canal.Nombre = txt_nombre_canal.Text;

        }

        private void btn_aceptar_canal_Click(object sender, EventArgs e)
        {
            try
            {

                LeerCanal();
                if (canal.Id == 0)
                {
                    canalBLL.CrearCanal(canal);
                }
                else
                {
                    canalBLL.ActualizarCanal(canal);
                }
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
