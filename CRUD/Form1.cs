using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public datos _datos = new datos();
        public CRUD _crud = new CRUD();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //cerrar el programa
            Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            _datos._nombre = tbxNombre.Text;
            try
            {
                _datos._numero = Double.Parse(tbxNumero.Text);
            }
            catch (Exception CS0029)// error por no poder hacer typecasting
            {
                MessageBox.Show("Debe ser un numero");
            }
            _crud.Create(_datos);


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRead_Click_1(object sender, EventArgs e)
        {
            //List<string> linealeida = new List<string>();
            String linealeida;
            linealeida = _crud.Read();
            lblResultado.Text = linealeida;
        }
    }
}
