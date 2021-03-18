namespace LUG_PIM2_Ana_Laura_Moyano.UI
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.grillaClientes = new System.Windows.Forms.DataGridView();
			this.grillaPaquetes = new System.Windows.Forms.DataGridView();
			this.grillaCanales = new System.Windows.Forms.DataGridView();
			this.grillaCanalesPorPaquetes = new System.Windows.Forms.DataGridView();
			this.grillaOrdenes = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_alta_cliente = new System.Windows.Forms.Button();
			this.btn_modificacion_cliente = new System.Windows.Forms.Button();
			this.btn_baja_cliente = new System.Windows.Forms.Button();
			this.btn_alta_paquete = new System.Windows.Forms.Button();
			this.btn_modificacion_paquete = new System.Windows.Forms.Button();
			this.btn_baja_paquete = new System.Windows.Forms.Button();
			this.btn_alta_canales = new System.Windows.Forms.Button();
			this.btn_modificacion_canales = new System.Windows.Forms.Button();
			this.btn_baja_canales = new System.Windows.Forms.Button();
			this.btn_alta_orden = new System.Windows.Forms.Button();
			this.btn_asociar_canales_con_paquetes = new System.Windows.Forms.Button();
			this.btn_borrar_asociacion = new System.Windows.Forms.Button();
			this.cmbMedioPago = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btn_baja_orden = new System.Windows.Forms.Button();
			this.btn_mayor_paquete = new System.Windows.Forms.Button();
			this.btn_menor_paquete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grillaPaquetes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grillaCanales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grillaCanalesPorPaquetes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grillaOrdenes)).BeginInit();
			this.SuspendLayout();
			// 
			// grillaClientes
			// 
			this.grillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grillaClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.grillaClientes.Location = new System.Drawing.Point(17, 46);
			this.grillaClientes.Margin = new System.Windows.Forms.Padding(2);
			this.grillaClientes.MultiSelect = false;
			this.grillaClientes.Name = "grillaClientes";
			this.grillaClientes.RowTemplate.Height = 24;
			this.grillaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grillaClientes.Size = new System.Drawing.Size(244, 122);
			this.grillaClientes.TabIndex = 0;
			// 
			// grillaPaquetes
			// 
			this.grillaPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grillaPaquetes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.grillaPaquetes.Location = new System.Drawing.Point(334, 46);
			this.grillaPaquetes.Margin = new System.Windows.Forms.Padding(2);
			this.grillaPaquetes.MultiSelect = false;
			this.grillaPaquetes.Name = "grillaPaquetes";
			this.grillaPaquetes.RowTemplate.Height = 24;
			this.grillaPaquetes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grillaPaquetes.Size = new System.Drawing.Size(252, 122);
			this.grillaPaquetes.TabIndex = 1;
			// 
			// grillaCanales
			// 
			this.grillaCanales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grillaCanales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.grillaCanales.Location = new System.Drawing.Point(653, 46);
			this.grillaCanales.Margin = new System.Windows.Forms.Padding(2);
			this.grillaCanales.MultiSelect = false;
			this.grillaCanales.Name = "grillaCanales";
			this.grillaCanales.RowTemplate.Height = 24;
			this.grillaCanales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grillaCanales.Size = new System.Drawing.Size(252, 122);
			this.grillaCanales.TabIndex = 2;
			// 
			// grillaCanalesPorPaquetes
			// 
			this.grillaCanalesPorPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grillaCanalesPorPaquetes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.grillaCanalesPorPaquetes.Location = new System.Drawing.Point(128, 257);
			this.grillaCanalesPorPaquetes.Margin = new System.Windows.Forms.Padding(2);
			this.grillaCanalesPorPaquetes.MultiSelect = false;
			this.grillaCanalesPorPaquetes.Name = "grillaCanalesPorPaquetes";
			this.grillaCanalesPorPaquetes.RowTemplate.Height = 24;
			this.grillaCanalesPorPaquetes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grillaCanalesPorPaquetes.Size = new System.Drawing.Size(244, 122);
			this.grillaCanalesPorPaquetes.TabIndex = 3;
			// 
			// grillaOrdenes
			// 
			this.grillaOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grillaOrdenes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.grillaOrdenes.Location = new System.Drawing.Point(496, 257);
			this.grillaOrdenes.Margin = new System.Windows.Forms.Padding(2);
			this.grillaOrdenes.MultiSelect = false;
			this.grillaOrdenes.Name = "grillaOrdenes";
			this.grillaOrdenes.RowTemplate.Height = 24;
			this.grillaOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grillaOrdenes.Size = new System.Drawing.Size(244, 122);
			this.grillaOrdenes.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Clientes";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(332, 15);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Paquetes";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(651, 15);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Canales";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(126, 232);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Canales por paquetes";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(494, 232);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Ordenes";
			// 
			// btn_alta_cliente
			// 
			this.btn_alta_cliente.Location = new System.Drawing.Point(17, 180);
			this.btn_alta_cliente.Margin = new System.Windows.Forms.Padding(2);
			this.btn_alta_cliente.Name = "btn_alta_cliente";
			this.btn_alta_cliente.Size = new System.Drawing.Size(68, 19);
			this.btn_alta_cliente.TabIndex = 10;
			this.btn_alta_cliente.Text = "Alta Cliente";
			this.btn_alta_cliente.UseVisualStyleBackColor = true;
			this.btn_alta_cliente.Click += new System.EventHandler(this.btn_alta_cliente_Click);
			// 
			// btn_modificacion_cliente
			// 
			this.btn_modificacion_cliente.Location = new System.Drawing.Point(101, 180);
			this.btn_modificacion_cliente.Margin = new System.Windows.Forms.Padding(2);
			this.btn_modificacion_cliente.Name = "btn_modificacion_cliente";
			this.btn_modificacion_cliente.Size = new System.Drawing.Size(76, 38);
			this.btn_modificacion_cliente.TabIndex = 11;
			this.btn_modificacion_cliente.Text = "Modificación Cliente";
			this.btn_modificacion_cliente.UseVisualStyleBackColor = true;
			this.btn_modificacion_cliente.Click += new System.EventHandler(this.btn_modificacion_cliente_Click);
			// 
			// btn_baja_cliente
			// 
			this.btn_baja_cliente.Location = new System.Drawing.Point(192, 180);
			this.btn_baja_cliente.Margin = new System.Windows.Forms.Padding(2);
			this.btn_baja_cliente.Name = "btn_baja_cliente";
			this.btn_baja_cliente.Size = new System.Drawing.Size(69, 19);
			this.btn_baja_cliente.TabIndex = 12;
			this.btn_baja_cliente.Text = "Baja Cliente";
			this.btn_baja_cliente.UseVisualStyleBackColor = true;
			this.btn_baja_cliente.Click += new System.EventHandler(this.btn_baja_cliente_Click);
			// 
			// btn_alta_paquete
			// 
			this.btn_alta_paquete.Location = new System.Drawing.Point(334, 180);
			this.btn_alta_paquete.Margin = new System.Windows.Forms.Padding(2);
			this.btn_alta_paquete.Name = "btn_alta_paquete";
			this.btn_alta_paquete.Size = new System.Drawing.Size(75, 19);
			this.btn_alta_paquete.TabIndex = 13;
			this.btn_alta_paquete.Text = "Alta Paquete";
			this.btn_alta_paquete.UseVisualStyleBackColor = true;
			this.btn_alta_paquete.Click += new System.EventHandler(this.btn_alta_paquete_Click);
			// 
			// btn_modificacion_paquete
			// 
			this.btn_modificacion_paquete.Location = new System.Drawing.Point(422, 180);
			this.btn_modificacion_paquete.Margin = new System.Windows.Forms.Padding(2);
			this.btn_modificacion_paquete.Name = "btn_modificacion_paquete";
			this.btn_modificacion_paquete.Size = new System.Drawing.Size(76, 39);
			this.btn_modificacion_paquete.TabIndex = 14;
			this.btn_modificacion_paquete.Text = "Modificación Paquete";
			this.btn_modificacion_paquete.UseVisualStyleBackColor = true;
			this.btn_modificacion_paquete.Click += new System.EventHandler(this.btn_modificacion_paquete_Click);
			// 
			// btn_baja_paquete
			// 
			this.btn_baja_paquete.Location = new System.Drawing.Point(510, 180);
			this.btn_baja_paquete.Margin = new System.Windows.Forms.Padding(2);
			this.btn_baja_paquete.Name = "btn_baja_paquete";
			this.btn_baja_paquete.Size = new System.Drawing.Size(76, 19);
			this.btn_baja_paquete.TabIndex = 15;
			this.btn_baja_paquete.Text = "Baja Paquete";
			this.btn_baja_paquete.UseVisualStyleBackColor = true;
			this.btn_baja_paquete.Click += new System.EventHandler(this.btn_baja_paquete_Click);
			// 
			// btn_alta_canales
			// 
			this.btn_alta_canales.Location = new System.Drawing.Point(653, 180);
			this.btn_alta_canales.Margin = new System.Windows.Forms.Padding(2);
			this.btn_alta_canales.Name = "btn_alta_canales";
			this.btn_alta_canales.Size = new System.Drawing.Size(72, 19);
			this.btn_alta_canales.TabIndex = 16;
			this.btn_alta_canales.Text = "Alta Canales";
			this.btn_alta_canales.UseVisualStyleBackColor = true;
			this.btn_alta_canales.Click += new System.EventHandler(this.btn_alta_canales_Click);
			// 
			// btn_modificacion_canales
			// 
			this.btn_modificacion_canales.Location = new System.Drawing.Point(744, 180);
			this.btn_modificacion_canales.Margin = new System.Windows.Forms.Padding(2);
			this.btn_modificacion_canales.Name = "btn_modificacion_canales";
			this.btn_modificacion_canales.Size = new System.Drawing.Size(75, 38);
			this.btn_modificacion_canales.TabIndex = 17;
			this.btn_modificacion_canales.Text = "Modificación Canales";
			this.btn_modificacion_canales.UseVisualStyleBackColor = true;
			this.btn_modificacion_canales.Click += new System.EventHandler(this.btn_modificacion_canales_Click);
			// 
			// btn_baja_canales
			// 
			this.btn_baja_canales.Location = new System.Drawing.Point(830, 180);
			this.btn_baja_canales.Margin = new System.Windows.Forms.Padding(2);
			this.btn_baja_canales.Name = "btn_baja_canales";
			this.btn_baja_canales.Size = new System.Drawing.Size(75, 19);
			this.btn_baja_canales.TabIndex = 18;
			this.btn_baja_canales.Text = "Baja Canales";
			this.btn_baja_canales.UseVisualStyleBackColor = true;
			this.btn_baja_canales.Click += new System.EventHandler(this.btn_baja_canales_Click);
			// 
			// btn_alta_orden
			// 
			this.btn_alta_orden.Location = new System.Drawing.Point(496, 396);
			this.btn_alta_orden.Margin = new System.Windows.Forms.Padding(2);
			this.btn_alta_orden.Name = "btn_alta_orden";
			this.btn_alta_orden.Size = new System.Drawing.Size(68, 19);
			this.btn_alta_orden.TabIndex = 19;
			this.btn_alta_orden.Text = "Alta Orden";
			this.btn_alta_orden.UseVisualStyleBackColor = true;
			this.btn_alta_orden.Click += new System.EventHandler(this.btn_alta_orden_Click);
			// 
			// btn_asociar_canales_con_paquetes
			// 
			this.btn_asociar_canales_con_paquetes.Location = new System.Drawing.Point(128, 396);
			this.btn_asociar_canales_con_paquetes.Margin = new System.Windows.Forms.Padding(2);
			this.btn_asociar_canales_con_paquetes.Name = "btn_asociar_canales_con_paquetes";
			this.btn_asociar_canales_con_paquetes.Size = new System.Drawing.Size(93, 44);
			this.btn_asociar_canales_con_paquetes.TabIndex = 20;
			this.btn_asociar_canales_con_paquetes.Text = "Asociar Canales Con Paquetes";
			this.btn_asociar_canales_con_paquetes.UseVisualStyleBackColor = true;
			this.btn_asociar_canales_con_paquetes.Click += new System.EventHandler(this.btn_asociar_canales_con_paquetes_Click);
			// 
			// btn_borrar_asociacion
			// 
			this.btn_borrar_asociacion.Location = new System.Drawing.Point(302, 396);
			this.btn_borrar_asociacion.Margin = new System.Windows.Forms.Padding(2);
			this.btn_borrar_asociacion.Name = "btn_borrar_asociacion";
			this.btn_borrar_asociacion.Size = new System.Drawing.Size(70, 43);
			this.btn_borrar_asociacion.TabIndex = 21;
			this.btn_borrar_asociacion.Text = "Borrar Asociación";
			this.btn_borrar_asociacion.UseVisualStyleBackColor = true;
			this.btn_borrar_asociacion.Click += new System.EventHandler(this.btn_borrar_asociacion_Click);
			// 
			// cmbMedioPago
			// 
			this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMedioPago.FormattingEnabled = true;
			this.cmbMedioPago.Location = new System.Drawing.Point(758, 285);
			this.cmbMedioPago.Name = "cmbMedioPago";
			this.cmbMedioPago.Size = new System.Drawing.Size(121, 21);
			this.cmbMedioPago.TabIndex = 22;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(758, 266);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 13);
			this.label6.TabIndex = 23;
			this.label6.Text = "Medio de Pago";
			// 
			// btn_baja_orden
			// 
			this.btn_baja_orden.Location = new System.Drawing.Point(665, 396);
			this.btn_baja_orden.Name = "btn_baja_orden";
			this.btn_baja_orden.Size = new System.Drawing.Size(75, 23);
			this.btn_baja_orden.TabIndex = 24;
			this.btn_baja_orden.Text = "Baja Orden";
			this.btn_baja_orden.UseVisualStyleBackColor = true;
			this.btn_baja_orden.Click += new System.EventHandler(this.btn_baja_orden_Click);
			// 
			// btn_mayor_paquete
			// 
			this.btn_mayor_paquete.Location = new System.Drawing.Point(761, 326);
			this.btn_mayor_paquete.Name = "btn_mayor_paquete";
			this.btn_mayor_paquete.Size = new System.Drawing.Size(144, 23);
			this.btn_mayor_paquete.TabIndex = 25;
			this.btn_mayor_paquete.Text = "Paquete mas solicitado";
			this.btn_mayor_paquete.UseVisualStyleBackColor = true;
			this.btn_mayor_paquete.Click += new System.EventHandler(this.btn_mayor_paquete_Click);
			// 
			// btn_menor_paquete
			// 
			this.btn_menor_paquete.Location = new System.Drawing.Point(761, 355);
			this.btn_menor_paquete.Name = "btn_menor_paquete";
			this.btn_menor_paquete.Size = new System.Drawing.Size(144, 23);
			this.btn_menor_paquete.TabIndex = 26;
			this.btn_menor_paquete.Text = "Paquete menos solicitado";
			this.btn_menor_paquete.UseVisualStyleBackColor = true;
			this.btn_menor_paquete.Click += new System.EventHandler(this.btn_menor_paquete_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 475);
			this.Controls.Add(this.btn_menor_paquete);
			this.Controls.Add(this.btn_mayor_paquete);
			this.Controls.Add(this.btn_baja_orden);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmbMedioPago);
			this.Controls.Add(this.btn_borrar_asociacion);
			this.Controls.Add(this.btn_asociar_canales_con_paquetes);
			this.Controls.Add(this.btn_alta_orden);
			this.Controls.Add(this.btn_baja_canales);
			this.Controls.Add(this.btn_modificacion_canales);
			this.Controls.Add(this.btn_alta_canales);
			this.Controls.Add(this.btn_baja_paquete);
			this.Controls.Add(this.btn_modificacion_paquete);
			this.Controls.Add(this.btn_alta_paquete);
			this.Controls.Add(this.btn_baja_cliente);
			this.Controls.Add(this.btn_modificacion_cliente);
			this.Controls.Add(this.btn_alta_cliente);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.grillaOrdenes);
			this.Controls.Add(this.grillaCanalesPorPaquetes);
			this.Controls.Add(this.grillaCanales);
			this.Controls.Add(this.grillaPaquetes);
			this.Controls.Add(this.grillaClientes);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grillaPaquetes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grillaCanales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grillaCanalesPorPaquetes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grillaOrdenes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.DataGridView grillaClientes;
        private System.Windows.Forms.DataGridView grillaPaquetes;
        private System.Windows.Forms.DataGridView grillaCanales;
        private System.Windows.Forms.DataGridView grillaCanalesPorPaquetes;
        private System.Windows.Forms.DataGridView grillaOrdenes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_alta_cliente;
        private System.Windows.Forms.Button btn_modificacion_cliente;
        private System.Windows.Forms.Button btn_baja_cliente;
        private System.Windows.Forms.Button btn_alta_paquete;
        private System.Windows.Forms.Button btn_modificacion_paquete;
        private System.Windows.Forms.Button btn_baja_paquete;
        private System.Windows.Forms.Button btn_alta_canales;
        private System.Windows.Forms.Button btn_modificacion_canales;
        private System.Windows.Forms.Button btn_baja_canales;
        private System.Windows.Forms.Button btn_alta_orden;
        private System.Windows.Forms.Button btn_asociar_canales_con_paquetes;
        private System.Windows.Forms.Button btn_borrar_asociacion;
		private System.Windows.Forms.ComboBox cmbMedioPago;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btn_baja_orden;
		private System.Windows.Forms.Button btn_mayor_paquete;
		private System.Windows.Forms.Button btn_menor_paquete;
	}
}

