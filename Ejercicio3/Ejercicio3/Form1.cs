using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Perro perro = new Perro();
        public Gato gato = new Gato();
        public Zorro zorro = new Zorro();
        public Lobo Lobo = new Lobo();
        public Leon Leon = new Leon();
        public List<string> felinus = new List<string>() { "Gato", "Leon" };
        public List<string> caninus = new List<string>() { "Perro", "Lobo", "Zorro" };
        // necestio los objetos afuera de otras dunciones para que sirvan para todo 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void rdbFelinos_CheckedChanged(object sender, EventArgs e)
        {
            rdbCaninus.Checked = false;
            cbxAnimal.Items.Clear();
            foreach (String anima in felinus)
            {
                cbxAnimal.Items.Add(anima);
            }
        }
        private void rdbCaninus_CheckedChanged(object sender, EventArgs e)
        {
            rdbFelinos.Checked = false;
            cbxAnimal.Items.Clear();
            foreach (String anima in caninus)
            {
                cbxAnimal.Items.Add(anima);
            }
        }

        private void cbxAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (rdbCaninus.Checked == true)
            {
                switch (cbxAnimal.SelectedItem)
                {
                    case "Perro"://perro
                        lblNomCient.Text = perro.GetNombreCientifico();
                        lblSonido.Text = perro.GetSonido();
                        lblAlimento.Text = perro.GetAlimento();
                        lblHabitat.Text = perro.GetHabitat();
                        break;
                    case "Lobo":// lobo
                        lblNomCient.Text = Lobo.GetNombreCientifico();
                        lblSonido.Text = Lobo.GetSonido();
                        lblAlimento.Text = Lobo.GetAlimento();
                        lblHabitat.Text = Lobo.GetHabitat();
                        break;
                    case "Zorro":// zorro
                        lblNomCient.Text = zorro.GetNombreCientifico();
                        lblSonido.Text = zorro.GetSonido();
                        lblAlimento.Text = zorro.GetAlimento();
                        lblHabitat.Text = zorro.GetHabitat();
                        break;
                }

            }
            else if (rdbFelinos.Checked == true)
            {
                switch (cbxAnimal.SelectedItem)
                {
                    case "Gato"://gato
                        lblNomCient.Text = gato.GetNombreCientifico();
                        lblSonido.Text = gato.GetSonido();
                        lblAlimento.Text = gato.GetAlimento();
                        lblHabitat.Text = gato.GetHabitat();
                        break;
                    case "leon"://leon
                        lblNomCient.Text = Leon.GetNombreCientifico();
                        lblSonido.Text = Leon.GetSonido();
                        lblAlimento.Text = Leon.GetAlimento();
                        lblHabitat.Text = Leon.GetHabitat();
                        break;

                }
            }
        }
    }

}

