namespace Ejercicio3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxAnimal = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNomCient = new System.Windows.Forms.Label();
            this.lblSonido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAlimento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHabitat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbCaninus = new System.Windows.Forms.RadioButton();
            this.rdbFelinos = new System.Windows.Forms.RadioButton();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Cientifico";
            // 
            // cbxAnimal
            // 
            this.cbxAnimal.FormattingEnabled = true;
            this.cbxAnimal.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Lobo",
            "Leon"});
            this.cbxAnimal.Location = new System.Drawing.Point(26, 117);
            this.cbxAnimal.Name = "cbxAnimal";
            this.cbxAnimal.Size = new System.Drawing.Size(167, 21);
            this.cbxAnimal.TabIndex = 1;
            this.cbxAnimal.SelectedIndexChanged += new System.EventHandler(this.cbxAnimal_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(529, 261);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNomCient
            // 
            this.lblNomCient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomCient.Location = new System.Drawing.Point(346, 52);
            this.lblNomCient.Name = "lblNomCient";
            this.lblNomCient.Size = new System.Drawing.Size(258, 25);
            this.lblNomCient.TabIndex = 5;
            // 
            // lblSonido
            // 
            this.lblSonido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonido.Location = new System.Drawing.Point(346, 96);
            this.lblSonido.Name = "lblSonido";
            this.lblSonido.Size = new System.Drawing.Size(258, 25);
            this.lblSonido.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sonido";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlimento
            // 
            this.lblAlimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlimento.Location = new System.Drawing.Point(346, 141);
            this.lblAlimento.Name = "lblAlimento";
            this.lblAlimento.Size = new System.Drawing.Size(258, 25);
            this.lblAlimento.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Alimentos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHabitat
            // 
            this.lblHabitat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHabitat.Location = new System.Drawing.Point(346, 189);
            this.lblHabitat.Name = "lblHabitat";
            this.lblHabitat.Size = new System.Drawing.Size(258, 25);
            this.lblHabitat.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Habitat";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Animal";
            // 
            // rdbCaninus
            // 
            this.rdbCaninus.AutoSize = true;
            this.rdbCaninus.Location = new System.Drawing.Point(26, 49);
            this.rdbCaninus.Name = "rdbCaninus";
            this.rdbCaninus.Size = new System.Drawing.Size(63, 17);
            this.rdbCaninus.TabIndex = 13;
            this.rdbCaninus.TabStop = true;
            this.rdbCaninus.Text = "Canidos";
            this.rdbCaninus.UseVisualStyleBackColor = true;
            this.rdbCaninus.CheckedChanged += new System.EventHandler(this.rdbCaninus_CheckedChanged);
            // 
            // rdbFelinos
            // 
            this.rdbFelinos.AutoSize = true;
            this.rdbFelinos.Location = new System.Drawing.Point(108, 51);
            this.rdbFelinos.Name = "rdbFelinos";
            this.rdbFelinos.Size = new System.Drawing.Size(58, 17);
            this.rdbFelinos.TabIndex = 14;
            this.rdbFelinos.TabStop = true;
            this.rdbFelinos.Text = "Felinos";
            this.rdbFelinos.UseVisualStyleBackColor = true;
            this.rdbFelinos.CheckedChanged += new System.EventHandler(this.rdbFelinos_CheckedChanged);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(38, 167);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 15;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 309);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.rdbFelinos);
            this.Controls.Add(this.rdbCaninus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblHabitat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAlimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSonido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNomCient);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cbxAnimal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxAnimal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNomCient;
        private System.Windows.Forms.Label lblSonido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAlimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHabitat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbCaninus;
        private System.Windows.Forms.RadioButton rdbFelinos;
        private System.Windows.Forms.Button btnMostrar;
    }
}

