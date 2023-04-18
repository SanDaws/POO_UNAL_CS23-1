namespace Ejercicio1
{
    partial class FrmNumerosIguales
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
            this.TxbNumA = new System.Windows.Forms.TextBox();
            this.TxbNumB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblRespuesta = new System.Windows.Forms.Label();
            this.BtnRespuesta = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxbNumA
            // 
            this.TxbNumA.Location = new System.Drawing.Point(82, 29);
            this.TxbNumA.Name = "TxbNumA";
            this.TxbNumA.Size = new System.Drawing.Size(100, 20);
            this.TxbNumA.TabIndex = 0;
            this.TxbNumA.TextChanged += new System.EventHandler(this.TxbNumA_TextChanged);
            // 
            // TxbNumB
            // 
            this.TxbNumB.Location = new System.Drawing.Point(315, 32);
            this.TxbNumB.Name = "TxbNumB";
            this.TxbNumB.Size = new System.Drawing.Size(100, 20);
            this.TxbNumB.TabIndex = 1;
            this.TxbNumB.TextChanged += new System.EventHandler(this.TxbNumB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero B:";
            // 
            // LblRespuesta
            // 
            this.LblRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRespuesta.Location = new System.Drawing.Point(25, 95);
            this.LblRespuesta.Name = "LblRespuesta";
            this.LblRespuesta.Size = new System.Drawing.Size(390, 81);
            this.LblRespuesta.TabIndex = 4;
            this.LblRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnRespuesta
            // 
            this.BtnRespuesta.Location = new System.Drawing.Point(179, 69);
            this.BtnRespuesta.Name = "BtnRespuesta";
            this.BtnRespuesta.Size = new System.Drawing.Size(75, 23);
            this.BtnRespuesta.TabIndex = 5;
            this.BtnRespuesta.Text = "Respuesta";
            this.BtnRespuesta.UseVisualStyleBackColor = true;
            this.BtnRespuesta.Click += new System.EventHandler(this.BtnRespuesta_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(340, 184);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salir.TabIndex = 6;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // FrmNumerosIguales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(437, 219);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.BtnRespuesta);
            this.Controls.Add(this.LblRespuesta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbNumB);
            this.Controls.Add(this.TxbNumA);
            this.Name = "FrmNumerosIguales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numeros Iguales";
            this.Load += new System.EventHandler(this.FrmNumerosIguales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxbNumA;
        private System.Windows.Forms.TextBox TxbNumB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblRespuesta;
        private System.Windows.Forms.Button BtnRespuesta;
        private System.Windows.Forms.Button Btn_Salir;
    }
}