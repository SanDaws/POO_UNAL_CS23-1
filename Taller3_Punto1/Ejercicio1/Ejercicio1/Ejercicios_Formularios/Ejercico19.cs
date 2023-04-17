using Ejercicio1.Ejercicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Ejercico19 : Form
    {
        TrianguloEquilatero _TE = new TrianguloEquilatero(); 

        public Ejercico19()
        {

            InitializeComponent();
        }

        private void Ejercico19_Load(object sender, EventArgs e)
        {

        }
        //cerrar
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Close();
            frmMenu.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            _TE._ladoTriangulo = float.Parse(TxbAltura.Text);
            LblArea.Text= _TE.Area().ToString();
            LblPerimtero.Text=_TE.Perimetro().ToString();
            LblAltura.Text= _TE.Altura().ToString();

        }

    }
}
