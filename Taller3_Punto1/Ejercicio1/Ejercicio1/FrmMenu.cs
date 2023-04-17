using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio1.Ejercicios;
using Ejercicio1.Ejercicios_Formularios;

namespace Ejercicio1
{
    public partial class FrmMenu : Form
    {

        public FrmMenu()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {}
        // boton de cerrar el programa
        private void button2_Click(object sender, EventArgs e)
        {
            //cierra toda la aplicacion
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // genera una descripcion del ejercicio por cada elelemto seleccionado
            switch (CmBox_Ejercicios.SelectedIndex)
            {
                
                case 0: // cp3 18
                    lbl_Resumen.Text = "Capitulo 3 ejericico 18: \n" +
                        "18. Se tiene la siguiente información de un empleado:\r\n·" +
                        " código del empleado,\r\n· nombres,\r\n· número de horas trabajadas al mes,\r\n· " +
                        "valor hora trabajada,\r\n· porcentaje de retención en la fuente.Haga un algoritmo que muestre: " +
                        "código, nombres, salario bruto y salario neto.";
                    break;
                case 1://cp 3 19
                    lbl_Resumen.Text = "Capitulo 3 ejercicio 19:\n"+
                        "19. Dado el valor del lado en un triángulo equilátero, haga un algoritmo que obtenga el\r\n" +
                        "perímetro, el valor de la altura y el área del triángulo.";
                    break;
                case 2:// cp4 7
                    lbl_Resumen.Text = "Capitulo 4 ejerccicio 7:\n" +
                        "Hacer un algoritmo que, dados dos valores numéricos A y B, " +
                        "escriba un mensaje diciendo\r\nsi A es mayor, menor o igual a B.";
                    break;
                case 3://  cp4 10
                    lbl_Resumen.Text = "Capitulo 4 ejerccicio 10:\n" +
                        "Cierta universidad para liquidar el pago de matrícula de un estudiante le exige los siguientes datos:" +
                        "\r\n• Número de inscripción\r\n• Nombres\r\n• Patrimonio.\r\n• Estrato social.";
                        break;
                case 4://cap4 22
                    lbl_Resumen.Text = "Capitulo 4 ejerccicio 22:\n" +
                        "22. Elaborar un algoritmo que entre el nombre de un empleado, su salario básico por hora y el\r\nnúmero de horas trabajadas en el mes;" +
                        " escriba su nombre y salario mensual si éste es mayor\r\nde " +
                        "$450.000, de lo contrario escriba sólo el nombre.";
                    break;
                case 5: // cp423
                    lbl_Resumen.Text = "Capitulo 4 ejerccicio 23:\n" +
                        "23. Dados los valores A, B y C que son los parámetros de una ecuación de segundo grado,\r\nelaborar un algoritmo para hallar las posibles soluciones de dicha ecuación.";
                    break;
                default:
                    lbl_Resumen.Text = "elije una opcion y veras el resumen aqui";
                    break;
            }
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            switch (CmBox_Ejercicios.SelectedIndex)
            {
                /*
                 estructura general 
                crea el formulario
                
                abre el nueo
                oculta el formulario usado(cierra)
                */
                case 0:
                    Ejercicio18 ejercicio18 = new Ejercicio18();
                    ejercicio18.Show();
                    this.Hide();

                    break;
                case 1:
                    Ejercico19 ejercico19 = new Ejercico19();
                    this.Hide();
                    ejercico19.Show();
                    break;
                case 2:
                    FrmNumerosIguales frmNumerosIguales= new FrmNumerosIguales();
                    this.Hide();
                    frmNumerosIguales.Show();
                    break;
                case 3:
                    FrmMatricula_Estudiantil matricula_Estudiantil= new FrmMatricula_Estudiantil();
                    this.Hide();
                    matricula_Estudiantil.Show();
                    break;
                case 4://cap4 22
                    FrmHora_laboral hora_Laboral= new FrmHora_laboral();   
                    this.Hide();
                    hora_Laboral.Show();
                    break;
                case 5: // cp4 23
                    FrmEcuSegundoGrado segundoGrado= new FrmEcuSegundoGrado(); 
                    this.Hide();
                    segundoGrado.Show();

                    break;
                default:
                    break;
            }
        }
    }
}
