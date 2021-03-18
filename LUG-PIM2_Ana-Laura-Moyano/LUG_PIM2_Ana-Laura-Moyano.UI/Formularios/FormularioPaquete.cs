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
    public partial class FormularioPaquete : Form
    {
        private Paquete paquete;
        private PaqueteBLL paqueteBLL;

        public FormularioPaquete(Paquete paquete, PaqueteBLL paqueteBLL)
        {
            InitializeComponent();

            this.paquete = paquete;
            this.paqueteBLL = paqueteBLL;
            LlenarCamposConPaquete();
        }

        private void FormularioPaquete_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_paquete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_paquete_Click(object sender, EventArgs e)
        {
            try
            {

                LeerPaquete();
                if(paquete.Id == 0)
                {
                    paqueteBLL.CrearPaquete(paquete);
                }
                else
                {
                    paqueteBLL.ActualizarPaquete(paquete);
                }
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        public void LlenarCamposConPaquete()
        {
            cbo_descripcion_paquete.SelectedItem = paquete.Descripcion;
            txt_descripcion_costo_paquete.Text = paquete.Costo.ToString();
            
        }

        public void LeerPaquete()
        {
            paquete.Descripcion = cbo_descripcion_paquete.SelectedItem.ToString();
            paquete.Costo = Convert.ToDecimal(txt_descripcion_costo_paquete.Text);
            
        }




    }
}
