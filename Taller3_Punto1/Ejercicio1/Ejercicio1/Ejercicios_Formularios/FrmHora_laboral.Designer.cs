namespace Ejercicio1.Ejercicios_Formularios
{
    partial class FrmHora_laboral
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
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tbxSalarioBase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.tbxHora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(202, 183);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salir.TabIndex = 1;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(32, 68);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(100, 20);
            this.tbxNombre.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(74, 183);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tbxSalarioBase
            // 
            this.tbxSalarioBase.Location = new System.Drawing.Point(204, 47);
            this.tbxSalarioBase.Name = "tbxSalarioBase";
            this.tbxSalarioBase.Size = new System.Drawing.Size(130, 20);
            this.tbxSalarioBase.TabIndex = 6;
            this.tbxSalarioBase.TextChanged += new System.EventHandler(this.tbxSalarioBase_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salario por horas:";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRespuesta.Location = new System.Drawing.Point(74, 116);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(203, 46);
            this.lblRespuesta.TabIndex = 7;
            this.lblRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxHora
            // 
            this.tbxHora.Location = new System.Drawing.Point(204, 84);
            this.tbxHora.Name = "tbxHora";
            this.tbxHora.Size = new System.Drawing.Size(130, 20);
            this.tbxHora.TabIndex = 9;
            this.tbxHora.TextChanged += new System.EventHandler(this.tbxHora_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Horas trabajadas:";
            // 
            // FrmHora_laboral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 232);
            this.Controls.Add(this.tbxHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.tbxSalarioBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Salir);
            this.Name = "FrmHora_laboral";
            this.Text = "Hora Laboral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tbxSalarioBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.TextBox tbxHora;
        private System.Windows.Forms.Label label3;
    }
}