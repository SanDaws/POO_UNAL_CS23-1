using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //permite la entrada a la funcion
              
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //cerrar el programa
            Close();
        }
    }
}
