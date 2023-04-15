namespace Ejercicio1
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBTitulo = new System.Windows.Forms.Label();
            this.lbl_Resumen = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBTitulo
            // 
            this.LBTitulo.AutoSize = true;
            this.LBTitulo.Location = new System.Drawing.Point(50, 28);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.Size = new System.Drawing.Size(153, 13);
            this.LBTitulo.TabIndex = 0;
            this.LBTitulo.Text = "Elija  el ejercicio que desea ver";
            // 
            // lbl_Resumen
            // 
            this.lbl_Resumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Resumen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Resumen.Location = new System.Drawing.Point(316, 27);
            this.lbl_Resumen.Name = "lbl_Resumen";
            this.lbl_Resumen.Size = new System.Drawing.Size(389, 259);
            this.lbl_Resumen.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Salario Empleados",
            "Triangulo Equilatero",
            "Numeros <=>",
            "Hora laboral",
            "Ecuacion de segundo grado",
            "Matricula Estudiantil",
            "Numeros Iguales",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(50, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Location = new System.Drawing.Point(329, 320);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Entrar.TabIndex = 3;
            this.btn_Entrar.Text = "Acceder";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Location = new System.Drawing.Point(533, 320);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cerrar.TabIndex = 4;
            this.Btn_Cerrar.Text = "Salir";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmMenu
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_Resumen);
            this.Controls.Add(this.LBTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de actividades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBTitulo;
        private System.Windows.Forms.Label lbl_Resumen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Button Btn_Cerrar;
    }
}

