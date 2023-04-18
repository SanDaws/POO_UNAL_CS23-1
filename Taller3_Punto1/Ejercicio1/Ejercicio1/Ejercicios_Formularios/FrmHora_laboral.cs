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
    public partial class FrmHora_laboral : Form
    {
        Ex_hora_laboral _HL=new Ex_hora_laboral();
        public FrmHora_laboral()
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
            _HL.Nombre=tbxNombre.Text;
            lblRespuesta.Text = _HL.Calcsalario();
        }

        private void tbxSalarioBase_TextChanged(object sender, EventArgs e)
        {
            _HL.salarioBase = double.Parse(tbxSalarioBase.Text);
        }

        private void tbxHora_TextChanged(object sender, EventArgs e)
        {
            _HL.horas = double.Parse(tbxHora.Text);
        }
    }
}
