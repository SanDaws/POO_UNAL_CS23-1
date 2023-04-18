namespace Ejercicio1.Ejercicios_Formularios
{
    partial class FrmMatricula_Estudiantil
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEstrato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPatrimonio = new System.Windows.Forms.TextBox();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.lblRepueta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(287, 182);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(165, 27);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero de matricula";
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(165, 77);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(100, 20);
            this.tbMatricula.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estrato";
            // 
            // tbEstrato
            // 
            this.tbEstrato.Location = new System.Drawing.Point(165, 127);
            this.tbEstrato.Name = "tbEstrato";
            this.tbEstrato.Size = new System.Drawing.Size(100, 20);
            this.tbEstrato.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Patrimonio";
            // 
            // tbPatrimonio
            // 
            this.tbPatrimonio.Location = new System.Drawing.Point(346, 127);
            this.tbPatrimonio.Name = "tbPatrimonio";
            this.tbPatrimonio.Size = new System.Drawing.Size(100, 20);
            this.tbPatrimonio.TabIndex = 7;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(398, 182);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salir.TabIndex = 11;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            // 
            // lblRepueta
            // 
            this.lblRepueta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRepueta.Location = new System.Drawing.Point(305, 27);
            this.lblRepueta.Name = "lblRepueta";
            this.lblRepueta.Size = new System.Drawing.Size(156, 70);
            this.lblRepueta.TabIndex = 12;
            // 
            // FrmMatricula_Estudiantil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 235);
            this.Controls.Add(this.lblRepueta);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPatrimonio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEstrato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnCalcular);
            this.Name = "FrmMatricula_Estudiantil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ex_Matricula_Estudiantil";
            this.Load += new System.EventHandler(this.FrmMatricula_Estudiantil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEstrato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPatrimonio;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Label lblRepueta;
    }
}