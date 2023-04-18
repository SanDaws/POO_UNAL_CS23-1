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
    public partial class FrmMatricula_Estudiantil : Form
    {
        Ex_Matricula_Estudiantil _ME= new Ex_Matricula_Estudiantil();
        public FrmMatricula_Estudiantil()
        {
            InitializeComponent();
        }

        private void FrmMatricula_Estudiantil_Load(object sender, EventArgs e)
        {

        }
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Close();
            frmMenu.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            _ME.nombre = tbNombre.Text;
            _ME.numInsc = int.Parse(tbMatricula.Text);
            _ME.estrato= int.Parse(tbEstrato.Text);
            _ME.patrimonio=float.Parse(tbPatrimonio.Text);
            _ME.matricula=float.Parse(tbMatricula.Text);

            lblRepueta.Text = _ME.CalcMatricula();

            
        }
    }
}
