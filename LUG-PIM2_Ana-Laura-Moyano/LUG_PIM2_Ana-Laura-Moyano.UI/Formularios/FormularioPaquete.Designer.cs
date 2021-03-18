namespace LUG_PIM2_Ana_Laura_Moyano.UI.Formularios
{
    partial class FormularioPaquete
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_descripcion_costo_paquete = new System.Windows.Forms.TextBox();
            this.btn_aceptar_paquete = new System.Windows.Forms.Button();
            this.btn_cancelar_paquete = new System.Windows.Forms.Button();
            this.cbo_descripcion_paquete = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Costo";
            // 
            // txt_descripcion_costo_paquete
            // 
            this.txt_descripcion_costo_paquete.Location = new System.Drawing.Point(289, 149);
            this.txt_descripcion_costo_paquete.Name = "txt_descripcion_costo_paquete";
            this.txt_descripcion_costo_paquete.Size = new System.Drawing.Size(100, 22);
            this.txt_descripcion_costo_paquete.TabIndex = 3;
            // 
            // btn_aceptar_paquete
            // 
            this.btn_aceptar_paquete.Location = new System.Drawing.Point(58, 353);
            this.btn_aceptar_paquete.Name = "btn_aceptar_paquete";
            this.btn_aceptar_paquete.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar_paquete.TabIndex = 4;
            this.btn_aceptar_paquete.Text = "Aceptar";
            this.btn_aceptar_paquete.UseVisualStyleBackColor = true;
            this.btn_aceptar_paquete.Click += new System.EventHandler(this.btn_aceptar_paquete_Click);
            // 
            // btn_cancelar_paquete
            // 
            this.btn_cancelar_paquete.Location = new System.Drawing.Point(311, 352);
            this.btn_cancelar_paquete.Name = "btn_cancelar_paquete";
            this.btn_cancelar_paquete.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_paquete.TabIndex = 5;
            this.btn_cancelar_paquete.Text = "Cancelar";
            this.btn_cancelar_paquete.UseVisualStyleBackColor = true;
            this.btn_cancelar_paquete.Click += new System.EventHandler(this.btn_cancelar_paquete_Click);
            // 
            // cbo_descripcion_paquete
            // 
            this.cbo_descripcion_paquete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_descripcion_paquete.FormattingEnabled = true;
            this.cbo_descripcion_paquete.Items.AddRange(new object[] {
            "SILVER",
            "PREMIUM",
            "GOLD"});
            this.cbo_descripcion_paquete.Location = new System.Drawing.Point(268, 94);
            this.cbo_descripcion_paquete.Name = "cbo_descripcion_paquete";
            this.cbo_descripcion_paquete.Size = new System.Drawing.Size(121, 24);
            this.cbo_descripcion_paquete.TabIndex = 6;
            // 
            // FormularioPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 517);
            this.Controls.Add(this.cbo_descripcion_paquete);
            this.Controls.Add(this.btn_cancelar_paquete);
            this.Controls.Add(this.btn_aceptar_paquete);
            this.Controls.Add(this.txt_descripcion_costo_paquete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioPaquete";
            this.Text = "FormularioPaquete";
            this.Load += new System.EventHandler(this.FormularioPaquete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_descripcion_costo_paquete;
        private System.Windows.Forms.Button btn_aceptar_paquete;
        private System.Windows.Forms.Button btn_cancelar_paquete;
        private System.Windows.Forms.ComboBox cbo_descripcion_paquete;
    }
}