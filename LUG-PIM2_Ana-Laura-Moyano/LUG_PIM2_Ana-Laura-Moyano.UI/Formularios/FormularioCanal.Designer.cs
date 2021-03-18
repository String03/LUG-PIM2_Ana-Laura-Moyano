namespace LUG_PIM2_Ana_Laura_Moyano.UI.Formularios
{
    partial class FormularioCanal
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
            this.btn_aceptar_canal = new System.Windows.Forms.Button();
            this.btn_cancelar_canal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo_canal = new System.Windows.Forms.TextBox();
            this.txt_nombre_canal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_aceptar_canal
            // 
            this.btn_aceptar_canal.Location = new System.Drawing.Point(108, 314);
            this.btn_aceptar_canal.Name = "btn_aceptar_canal";
            this.btn_aceptar_canal.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar_canal.TabIndex = 0;
            this.btn_aceptar_canal.Text = "Aceptar";
            this.btn_aceptar_canal.UseVisualStyleBackColor = true;
            this.btn_aceptar_canal.Click += new System.EventHandler(this.btn_aceptar_canal_Click);
            // 
            // btn_cancelar_canal
            // 
            this.btn_cancelar_canal.Location = new System.Drawing.Point(411, 314);
            this.btn_cancelar_canal.Name = "btn_cancelar_canal";
            this.btn_cancelar_canal.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_canal.TabIndex = 1;
            this.btn_cancelar_canal.Text = "Cancelar";
            this.btn_cancelar_canal.UseVisualStyleBackColor = true;
            this.btn_cancelar_canal.Click += new System.EventHandler(this.btn_cancelar_canal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // txt_codigo_canal
            // 
            this.txt_codigo_canal.Location = new System.Drawing.Point(386, 78);
            this.txt_codigo_canal.MaxLength = 10;
            this.txt_codigo_canal.Name = "txt_codigo_canal";
            this.txt_codigo_canal.Size = new System.Drawing.Size(100, 22);
            this.txt_codigo_canal.TabIndex = 4;
            // 
            // txt_nombre_canal
            // 
            this.txt_nombre_canal.Location = new System.Drawing.Point(385, 128);
            this.txt_nombre_canal.MaxLength = 20;
            this.txt_nombre_canal.Name = "txt_nombre_canal";
            this.txt_nombre_canal.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre_canal.TabIndex = 5;
            // 
            // FormularioCanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 448);
            this.Controls.Add(this.txt_nombre_canal);
            this.Controls.Add(this.txt_codigo_canal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar_canal);
            this.Controls.Add(this.btn_aceptar_canal);
            this.Name = "FormularioCanal";
            this.Text = "FormularioCanal";
            this.Load += new System.EventHandler(this.FormularioCanal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aceptar_canal;
        private System.Windows.Forms.Button btn_cancelar_canal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo_canal;
        private System.Windows.Forms.TextBox txt_nombre_canal;
    }
}