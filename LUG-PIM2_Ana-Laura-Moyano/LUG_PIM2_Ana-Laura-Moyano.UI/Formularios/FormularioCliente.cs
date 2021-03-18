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
	public partial class FormularioCliente : Form
	{
		private Cliente cliente;
		private ClienteBLL clienteBLL;

		public FormularioCliente(Cliente cliente, ClienteBLL clienteBLL)
		{
			InitializeComponent();
			if (cliente == null)
			{
				this.cliente = new Cliente();
			}
			else
			{
				this.cliente = cliente;
			}
			this.clienteBLL = clienteBLL;
			LlenarCamposConCliente();
		}

		private void btn_cancelar_cliente_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		public void LlenarCamposConCliente()
		{
			txt_nombre_cliente.Text = cliente.Nombre;
			txt_apellido_cliente.Text = cliente.Apellido;
			txt_dni_cliente.Text = cliente.Dni;
			dt_fecha_de_nacimiento_cliente.Value = cliente.FechaNacimiento;
		}

		public void LeerCliente()
		{
			cliente.Nombre = txt_nombre_cliente.Text;
			cliente.Apellido = txt_apellido_cliente.Text;
			cliente.Dni = txt_dni_cliente.Text;
			cliente.FechaNacimiento = dt_fecha_de_nacimiento_cliente.Value;
		}

		private void btn_aceptar_cliente_Click(object sender, EventArgs e)
		{
			try
			{
				LeerCliente();
				if (cliente.Id == 0)
				{
					clienteBLL.CrearCliente(cliente);
				}
				else
				{
					clienteBLL.ActualizarCliente(cliente);
				}
				this.Close();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}

		}

        private void FormularioCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
