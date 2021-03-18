namespace LUG_PIM2_Ana_Laura_Moyano.UI.Formularios
{
    partial class FormularioCliente
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
			this.btn_cancelar_cliente = new System.Windows.Forms.Button();
			this.btn_aceptar_cliente = new System.Windows.Forms.Button();
			this.dt_fecha_de_nacimiento_cliente = new System.Windows.Forms.DateTimePicker();
			this.txt_nombre_cliente = new System.Windows.Forms.TextBox();
			this.txt_apellido_cliente = new System.Windows.Forms.TextBox();
			this.txt_dni_cliente = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_cancelar_cliente
			// 
			this.btn_cancelar_cliente.Location = new System.Drawing.Point(264, 288);
			this.btn_cancelar_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_cancelar_cliente.Name = "btn_cancelar_cliente";
			this.btn_cancelar_cliente.Size = new System.Drawing.Size(56, 19);
			this.btn_cancelar_cliente.TabIndex = 0;
			this.btn_cancelar_cliente.Text = "Cancelar";
			this.btn_cancelar_cliente.UseVisualStyleBackColor = true;
			this.btn_cancelar_cliente.Click += new System.EventHandler(this.btn_cancelar_cliente_Click);
			// 
			// btn_aceptar_cliente
			// 
			this.btn_aceptar_cliente.Location = new System.Drawing.Point(97, 288);
			this.btn_aceptar_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_aceptar_cliente.Name = "btn_aceptar_cliente";
			this.btn_aceptar_cliente.Size = new System.Drawing.Size(56, 19);
			this.btn_aceptar_cliente.TabIndex = 1;
			this.btn_aceptar_cliente.Text = "Aceptar";
			this.btn_aceptar_cliente.UseVisualStyleBackColor = true;
			this.btn_aceptar_cliente.Click += new System.EventHandler(this.btn_aceptar_cliente_Click);
			// 
			// dt_fecha_de_nacimiento_cliente
			// 
			this.dt_fecha_de_nacimiento_cliente.Location = new System.Drawing.Point(232, 137);
			this.dt_fecha_de_nacimiento_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dt_fecha_de_nacimiento_cliente.Name = "dt_fecha_de_nacimiento_cliente";
			this.dt_fecha_de_nacimiento_cliente.Size = new System.Drawing.Size(151, 20);
			this.dt_fecha_de_nacimiento_cliente.TabIndex = 2;
			// 
			// txt_nombre_cliente
			// 
			this.txt_nombre_cliente.Location = new System.Drawing.Point(307, 41);
			this.txt_nombre_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_nombre_cliente.MaxLength = 50;
			this.txt_nombre_cliente.Name = "txt_nombre_cliente";
			this.txt_nombre_cliente.Size = new System.Drawing.Size(76, 20);
			this.txt_nombre_cliente.TabIndex = 5;
			// 
			// txt_apellido_cliente
			// 
			this.txt_apellido_cliente.Location = new System.Drawing.Point(307, 72);
			this.txt_apellido_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_apellido_cliente.MaxLength = 50;
			this.txt_apellido_cliente.Name = "txt_apellido_cliente";
			this.txt_apellido_cliente.Size = new System.Drawing.Size(76, 20);
			this.txt_apellido_cliente.TabIndex = 6;
			// 
			// txt_dni_cliente
			// 
			this.txt_dni_cliente.Location = new System.Drawing.Point(307, 103);
			this.txt_dni_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_dni_cliente.MaxLength = 50;
			this.txt_dni_cliente.Name = "txt_dni_cliente";
			this.txt_dni_cliente.Size = new System.Drawing.Size(76, 20);
			this.txt_dni_cliente.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 46);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 76);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Apellido";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(50, 103);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "DNI";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(52, 137);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Fecha De Nacimiento";
			// 
			// FormularioCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(426, 370);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_dni_cliente);
			this.Controls.Add(this.txt_apellido_cliente);
			this.Controls.Add(this.txt_nombre_cliente);
			this.Controls.Add(this.dt_fecha_de_nacimiento_cliente);
			this.Controls.Add(this.btn_aceptar_cliente);
			this.Controls.Add(this.btn_cancelar_cliente);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FormularioCliente";
			this.Text = "FormularioCliente";
			this.Load += new System.EventHandler(this.FormularioCliente_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar_cliente;
        private System.Windows.Forms.Button btn_aceptar_cliente;
        private System.Windows.Forms.DateTimePicker dt_fecha_de_nacimiento_cliente;
        private System.Windows.Forms.TextBox txt_nombre_cliente;
        private System.Windows.Forms.TextBox txt_apellido_cliente;
        private System.Windows.Forms.TextBox txt_dni_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}