namespace Ejercicio1
{
    partial class Ejercico19
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.TxbAltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblPerimtero = new System.Windows.Forms.Label();
            this.LblArea = new System.Windows.Forms.Label();
            this.LblAltura = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(237, 193);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salir.TabIndex = 1;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(26, 40);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(34, 13);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "Lado:";
            // 
            // TxbAltura
            // 
            this.TxbAltura.Location = new System.Drawing.Point(67, 37);
            this.TxbAltura.Name = "TxbAltura";
            this.TxbAltura.Size = new System.Drawing.Size(115, 20);
            this.TxbAltura.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(188, 40);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Perimetro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Altura";
            // 
            // LblPerimtero
            // 
            this.LblPerimtero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPerimtero.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LblPerimtero.Enabled = false;
            this.LblPerimtero.Location = new System.Drawing.Point(67, 113);
            this.LblPerimtero.Name = "LblPerimtero";
            this.LblPerimtero.Size = new System.Drawing.Size(196, 18);
            this.LblPerimtero.TabIndex = 17;
            // 
            // LblArea
            // 
            this.LblArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblArea.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LblArea.Enabled = false;
            this.LblArea.Location = new System.Drawing.Point(67, 84);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(196, 18);
            this.LblArea.TabIndex = 16;
            // 
            // LblAltura
            // 
            this.LblAltura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAltura.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LblAltura.Enabled = false;
            this.LblAltura.Location = new System.Drawing.Point(67, 144);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(196, 18);
            this.LblAltura.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Triangulo equilatero";
            // 
            // Ejercico19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 244);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.LblPerimtero);
            this.Controls.Add(this.LblArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.TxbAltura);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.Btn_Salir);
            this.MaximizeBox = false;
            this.Name = "Ejercico19";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercico19";
            this.Load += new System.EventHandler(this.Ejercico19_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TextBox TxbAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblPerimtero;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.Label label5;
    }
}