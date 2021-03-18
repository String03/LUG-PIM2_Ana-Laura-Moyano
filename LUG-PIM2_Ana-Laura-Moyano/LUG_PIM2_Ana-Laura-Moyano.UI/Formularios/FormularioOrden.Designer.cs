namespace LUG_PIM2_Ana_Laura_Moyano.UI.Formularios
{
    partial class FormularioOrden
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
            this.cmb_cliente_orden = new System.Windows.Forms.ComboBox();
            this.cmb_paquete_orden = new System.Windows.Forms.ComboBox();
            this.cmb_forma_de_pago_orden = new System.Windows.Forms.ComboBox();
            this.btn_aceptar_orden = new System.Windows.Forms.Button();
            this.btn_cancelar_orden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_cliente_orden
            // 
            this.cmb_cliente_orden.FormattingEnabled = true;
            this.cmb_cliente_orden.Location = new System.Drawing.Point(414, 88);
            this.cmb_cliente_orden.Name = "cmb_cliente_orden";
            this.cmb_cliente_orden.Size = new System.Drawing.Size(121, 24);
            this.cmb_cliente_orden.TabIndex = 0;
            // 
            // cmb_paquete_orden
            // 
            this.cmb_paquete_orden.FormattingEnabled = true;
            this.cmb_paquete_orden.Location = new System.Drawing.Point(414, 147);
            this.cmb_paquete_orden.Name = "cmb_paquete_orden";
            this.cmb_paquete_orden.Size = new System.Drawing.Size(121, 24);
            this.cmb_paquete_orden.TabIndex = 1;
            // 
            // cmb_forma_de_pago_orden
            // 
            this.cmb_forma_de_pago_orden.FormattingEnabled = true;
            this.cmb_forma_de_pago_orden.Location = new System.Drawing.Point(414, 208);
            this.cmb_forma_de_pago_orden.MaxLength = 20;
            this.cmb_forma_de_pago_orden.Name = "cmb_forma_de_pago_orden";
            this.cmb_forma_de_pago_orden.Size = new System.Drawing.Size(121, 24);
            this.cmb_forma_de_pago_orden.TabIndex = 2;
            // 
            // btn_aceptar_orden
            // 
            this.btn_aceptar_orden.Location = new System.Drawing.Point(174, 375);
            this.btn_aceptar_orden.Name = "btn_aceptar_orden";
            this.btn_aceptar_orden.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar_orden.TabIndex = 3;
            this.btn_aceptar_orden.Text = "Aceptar";
            this.btn_aceptar_orden.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar_orden
            // 
            this.btn_cancelar_orden.Location = new System.Drawing.Point(442, 375);
            this.btn_cancelar_orden.Name = "btn_cancelar_orden";
            this.btn_cancelar_orden.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_orden.TabIndex = 4;
            this.btn_cancelar_orden.Text = "Cancelar";
            this.btn_cancelar_orden.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Paquete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Formas de Pago";
            // 
            // FormularioOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar_orden);
            this.Controls.Add(this.btn_aceptar_orden);
            this.Controls.Add(this.cmb_forma_de_pago_orden);
            this.Controls.Add(this.cmb_paquete_orden);
            this.Controls.Add(this.cmb_cliente_orden);
            this.Name = "FormularioOrden";
            this.Text = "FormularioOrden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_cliente_orden;
        private System.Windows.Forms.ComboBox cmb_paquete_orden;
        private System.Windows.Forms.ComboBox cmb_forma_de_pago_orden;
        private System.Windows.Forms.Button btn_aceptar_orden;
        private System.Windows.Forms.Button btn_cancelar_orden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}