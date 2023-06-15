namespace Punto1
{
    partial class Principal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblDesviacion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaxNota = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMinNota = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.Nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nota1,
            this.Nota2,
            this.Nota3,
            this.Nota4,
            this.Nota5});
            this.dataGridView1.Location = new System.Drawing.Point(38, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 59);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(544, 299);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Promedio Notas";
            // 
            // lblPromedio
            // 
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(349, 124);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(270, 25);
            this.lblPromedio.TabIndex = 4;
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesviacion
            // 
            this.lblDesviacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDesviacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesviacion.Location = new System.Drawing.Point(349, 166);
            this.lblDesviacion.Name = "lblDesviacion";
            this.lblDesviacion.Size = new System.Drawing.Size(270, 25);
            this.lblDesviacion.TabIndex = 6;
            this.lblDesviacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Desviacion Estandar";
            // 
            // lblMaxNota
            // 
            this.lblMaxNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaxNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxNota.Location = new System.Drawing.Point(349, 210);
            this.lblMaxNota.Name = "lblMaxNota";
            this.lblMaxNota.Size = new System.Drawing.Size(270, 25);
            this.lblMaxNota.TabIndex = 8;
            this.lblMaxNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nota más alta";
            // 
            // lblMinNota
            // 
            this.lblMinNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMinNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinNota.Location = new System.Drawing.Point(349, 249);
            this.lblMinNota.Name = "lblMinNota";
            this.lblMinNota.Size = new System.Drawing.Size(270, 25);
            this.lblMinNota.TabIndex = 10;
            this.lblMinNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nota más baja";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(38, 117);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // Nota1
            // 
            this.Nota1.HeaderText = "Nota1";
            this.Nota1.MaxInputLength = 3;
            this.Nota1.Name = "Nota1";
            // 
            // Nota2
            // 
            this.Nota2.HeaderText = "Nota2";
            this.Nota2.MaxInputLength = 3;
            this.Nota2.Name = "Nota2";
            // 
            // Nota3
            // 
            this.Nota3.HeaderText = "Nota 3";
            this.Nota3.MaxInputLength = 3;
            this.Nota3.Name = "Nota3";
            // 
            // Nota4
            // 
            this.Nota4.HeaderText = "Nota 4";
            this.Nota4.MaxInputLength = 3;
            this.Nota4.Name = "Nota4";
            // 
            // Nota5
            // 
            this.Nota5.HeaderText = "Nota5";
            this.Nota5.MaxInputLength = 3;
            this.Nota5.Name = "Nota5";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 334);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMinNota);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMaxNota);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDesviacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Principal";
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblDesviacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaxNota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMinNota;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota5;
    }
}

