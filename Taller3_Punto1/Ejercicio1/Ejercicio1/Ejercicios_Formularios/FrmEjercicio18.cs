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
    public partial class Ejercicio18 : Form
    {
        SalarioN _salario= new SalarioN();

        public Ejercicio18()
        {
            InitializeComponent();

        }

        private void Ejercicio15_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();   
            this.Close();
            frmMenu.Show();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            _salario.nombre = TxbNomEmpleado.Text;
            _salario.codigo = int.Parse(TxbCodEmple.Text);
            _salario.valHoras = double.Parse(TxbValHora.Text);
            _salario.horas = int.Parse(TxbHoTrabaja.Text);
            _salario.retencion= double.Parse(TxbRetencion.Text);

            LblRespBruto.Text= _salario.calSalarioBase().ToString();
            LblResSalarioNeto.Text=_salario.calSalarioNeto().ToString();

        }
    }
}
