using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo4.Clases;
using Trabajo4.Diseño;
using Trabajo4.Forms;

namespace Trabajo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //entrega una pequeña descripcion del diguietne ejercicio
            switch (cbxLinea.SelectedIndex) {
                case 0://ejercicio3

                    break;
                case 1: // ejercicio4
                    break; 
                case 2://ejercicio5
                    break;
                default:
                    lblResumen.Text = "Elija una opcion";
                    break;



            }

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
           // if (cbxLinea.SelectedIndex== default || cbxLinea.SelectedIndex==)
            
            //permite la entrada a la funcion
            switch (cbxLinea.SelectedIndex)
            {
                case 0:
                    FrmActividad3 frmActividad3 = new FrmActividad3();
                    frmActividad3.Show();
                    this.Hide();
                    break;
                case 1:
                    FrmActividad4 frmActividad4= new FrmActividad4();
                    frmActividad4.Show();
                    this.Hide(); 
                    break;
             
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //cerrar el programa
            Close();
        }
    }
}
