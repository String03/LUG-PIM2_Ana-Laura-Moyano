using LUG_PIM2_Ana_Laura_Moyano.BLL;
using LUG_PIM2_Ana_Laura_Moyano.DAL;
using LUG_PIM2_Ana_Laura_Moyano.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUG_PIM2_Ana_Laura_Moyano.UI
{
	public partial class Form1 : Form
	{

		private PaqueteBLL paqueteBLL;
		private ClienteBLL clienteBLL;
        private CanalBLL canalBLL;
		private OrdenesBLL ordenesBLL;
			
		public Form1()
		{
			InitializeComponent();

			// Inicializar los BLL.
			string connectionString = ConfigurationManager.ConnectionStrings["CableDB"].ConnectionString;
			clienteBLL = new ClienteBLL(connectionString);
            paqueteBLL = new PaqueteBLL(connectionString);
            canalBLL = new CanalBLL(connectionString);
			ordenesBLL = new OrdenesBLL(connectionString);
			////////////////////////////////////////

			// Inicializar las grillas.
			RefrescarGrillaClientes();
            RefrescarGrillaPaquetes();
            RefrescarGrillaCanales();
			RefrescarGrillaCanalesPorPaquetes();
			RefrescarGrillaOrdenes();
			CargarMetodosDePago();
            ////////////////////////////////////////
        }

		private void RefrescarGrillaOrdenes()
		{
			grillaOrdenes.DataSource = null;
			grillaOrdenes.DataSource = ordenesBLL.ListarOrdenes();
		}

		private void CargarMetodosDePago()
		{
			cmbMedioPago.DisplayMember = "Name";
			cmbMedioPago.ValueMember = "Id";

			cmbMedioPago.Items.Add(new { Name = "Tarjeta de Credito", Id = FormasDePago.TarjetaCredito });
			cmbMedioPago.Items.Add(new { Name = "Efectivo", Id = FormasDePago.Efectivo });
			cmbMedioPago.Items.Add(new { Name = "Debito Automatico", Id = FormasDePago.DebitoAutomatico });
		}

		private void btn_alta_cliente_Click(object sender, EventArgs e)
		{
			new Formularios.FormularioCliente(new Cliente(), clienteBLL).Show(this);
			
		}

		private void btn_alta_paquete_Click(object sender, EventArgs e)
		{
			new Formularios.FormularioPaquete(new Paquete(), paqueteBLL).Show(this);
            
		}

		private void RefrescarGrillaClientes()
		{
			grillaClientes.DataSource = null;
			grillaClientes.DataSource = clienteBLL.BuscarClientes();
		}

        private void RefrescarGrillaPaquetes()
        {
            grillaPaquetes.DataSource = null;
            grillaPaquetes.DataSource = paqueteBLL.ListarPaquete();
        }

        private void RefrescarGrillaCanales()
        {
            grillaCanales.DataSource = null;
            grillaCanales.DataSource = canalBLL.BuscarCanales();
        }

		private void RefrescarGrillaCanalesPorPaquetes()
		{
			grillaCanalesPorPaquetes.DataSource = null;
			grillaCanalesPorPaquetes.DataSource = paqueteBLL.ListarCanalesPorPaquetes();
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            clienteBLL.ActualizacionCliente += (o, s) => RefrescarGrillaClientes();
            paqueteBLL.ActualizacionPaquete += (o, s) => RefrescarGrillaPaquetes();
            canalBLL.ActualizacionCanal += (o, s) => RefrescarGrillaCanales();
        }

        private void btn_modificacion_cliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente;
                try
                {
                    cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;


                }
                catch (Exception)
                {

                    throw new Exception("Debe elegir un cliente de la grilla");
                }
                new Formularios.FormularioCliente(cliente, clienteBLL).Show(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message);
            }
        }

        private void btn_baja_cliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente;
                try
                {
                    cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;


                }
                catch (Exception)
                {

                    throw new Exception("Debe eliminar un cliente");
                }
                clienteBLL.BorrarCliente(cliente);
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message);
            }
        }

        private void btn_modificacion_paquete_Click(object sender, EventArgs e)
        {
            try
            {
                Paquete paquete;
                try
                {
                    paquete = grillaPaquetes.SelectedRows[0].DataBoundItem as Paquete;


                }
                catch (Exception)
                {

                    throw new Exception("Debe modificar un paquete");
                }
                new Formularios.FormularioPaquete(paquete, paqueteBLL).Show(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message);
            }
        }

        private void btn_baja_paquete_Click(object sender, EventArgs e)
        {
            try
            {
                Paquete paquete;
                try
                {
                    paquete = grillaPaquetes.SelectedRows[0].DataBoundItem as Paquete;


                }
                catch (Exception)
                {

                    throw new Exception("Debe eliminar un paquete");
                }
                paqueteBLL.BorrarPaquete(paquete);
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message);
            }
        }

        private void btn_alta_canales_Click(object sender, EventArgs e)
        {
            new Formularios.FormularioCanal(new Canal(), canalBLL).Show(this);
        }

        private void btn_modificacion_canales_Click(object sender, EventArgs e)
        {
            try
            {
                Canal canal;
                try
                {
                    canal = grillaCanales.SelectedRows[0].DataBoundItem as Canal;


                }
                catch (Exception)
                {

                    throw new Exception("Debe modificar un canal");
                }
                new Formularios.FormularioCanal(canal, canalBLL).Show(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message);
            }
        }

        private void btn_baja_canales_Click(object sender, EventArgs e)
        {
            try
            {
                Canal canal;
				try
				{
					canal = grillaCanales.SelectedRows[0].DataBoundItem as Canal;
				}
				catch (Exception)
				{

					throw new Exception("Debe eliminar un paquete");
				}
                canalBLL.BorrarCanal(canal);
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message);
            }
        }

		private void btn_asociar_canales_con_paquetes_Click(object sender, EventArgs e)
		{
			try
			{
				Canal canal;
				try
				{
					canal = grillaCanales.SelectedRows[0].DataBoundItem as Canal;
				}
				catch
				{
					throw new Exception("Debe de seleccionar un canal.");
				}

				Paquete paquete;
				try
				{
					paquete = grillaPaquetes.SelectedRows[0].DataBoundItem as Paquete;
				}
				catch
				{
					throw new Exception("Debe de seleccionar un paquete.");
				}

				paqueteBLL.AsociarPaqueteCanal(paquete, canal);
				RefrescarGrillaCanalesPorPaquetes();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btn_borrar_asociacion_Click(object sender, EventArgs e)
		{
			try
			{
				PaquetesCanales paquetesCanales;
				try
				{
					paquetesCanales = grillaCanalesPorPaquetes.SelectedRows[0].DataBoundItem as PaquetesCanales;
				}
				catch
				{
					throw new Exception("Debe seleccionar una relacion entre paquete y canal.");
				}

				paqueteBLL.BorrarCanalDePaquete(paquetesCanales);
				RefrescarGrillaCanalesPorPaquetes();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btn_alta_orden_Click(object sender, EventArgs e)
		{
			try
			{
                Cliente cliente;
                try
                {
                    cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                }
                catch (Exception)
                {

                    throw new Exception("Debe eliminar un cliente");
                }

				Paquete paquete;
				try
				{
					paquete = grillaPaquetes.SelectedRows[0].DataBoundItem as Paquete;
				}
				catch
				{
					throw new Exception("Debe de seleccionar un paquete.");
				}

				if (cmbMedioPago.SelectedItem == null)
					throw new Exception("Seleccionar forma de pago");

				ordenesBLL.CrearNuevaOrden(cliente, paquete, ((FormasDePago)((dynamic)cmbMedioPago.SelectedItem).Id));
				RefrescarGrillaOrdenes();
				RefrescarGrillaClientes();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btn_baja_orden_Click(object sender, EventArgs e)
		{
			try
			{
				Orden orden;
				try
				{
					orden = grillaOrdenes.SelectedRows[0].DataBoundItem as Orden;
				}
				catch (Exception ex)
				{
					throw new Exception("Debe de seleccionar una order");
				}
				ordenesBLL.EliminarOrden(orden);
				RefrescarGrillaOrdenes();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btn_mayor_paquete_Click(object sender, EventArgs e)
		{
			try
			{
				Paquete paquete = paqueteBLL.ObtenerPaqueteMasSolicitado();
				MessageBox.Show("El paquete mas solicitado es " + paquete.Descripcion);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btn_menor_paquete_Click(object sender, EventArgs e)
		{
			try
			{
				Paquete paquete = paqueteBLL.ObtenerPaqueteMenosSolicitado();
				MessageBox.Show("El paquete menos solicitado es " + paquete.Descripcion);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
