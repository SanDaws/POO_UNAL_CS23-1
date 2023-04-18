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

namespace Ejercicio1.Ejercicios_Formularios
{
    public partial class FrmEcuSegundoGrado : Form
    {
        Ex_EcuSegundoGrado _SG=new Ex_EcuSegundoGrado();
        public FrmEcuSegundoGrado()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Close();
            frmMenu.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //esto no se si se pueda hacer mas optimo poniendo cada uno en su respectiva textbox
            _SG.A=double.Parse(txbA.Text);
            _SG.B=double.Parse(txbB.Text);
            _SG.C = double.Parse(tbxC.Text);

            _SG.determinante();
            _SG.ecuacion();

            lblSol1.Text = _SG.Val1.ToString();
            lblSolucion2.Text = _SG.Val2.ToString();

        }
    }
}
