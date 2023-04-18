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
    public partial class FrmNumerosIguales : Form
    {
        Ex_NumerosIguales _NI = new Ex_NumerosIguales();

        public FrmNumerosIguales()
        {
            InitializeComponent();
        }

        private void FrmNumerosIguales_Load(object sender, EventArgs e)
        {
          /*
           Si ha visto los anteriroes ejercicios, este espacio permanece en blanco, lo que sucede es que este metodo de la funcion
          se activa cuando carga la primera vez, pero al mismo teipo carga por primera vez el formulario
          Ya lo he retirado antes y el formulario por si mismo no funciona.
           */
        }
        //cerrar
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Close();
            frmMenu.Show();
        }

        private void BtnRespuesta_Click(object sender, EventArgs e)
        {
            
            _NI.NumeroA = double.Parse(TxbNumA.Text);
            _NI.NumeroB = double.Parse(TxbNumB.Text);

            LblRespuesta.Text = _NI.NumeroMIm();
        }

        private void TxbNumA_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxbNumB_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
