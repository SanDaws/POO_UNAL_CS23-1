using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Ejercicios
{
    internal class Ex_Matricula_Estudiantil
    {
        private int _numInsc, _estrato, _matricula;
        private String _nombre;
        private float _patrimonio;

        public Ex_Matricula_Estudiantil() { }


        public int numInsc
        {
            get { return _numInsc; }
            set { _numInsc = value; }
        }
        public int estrato
        {
            get { return _estrato; }
            set { _estrato = value; }
        }
        public float patrimonio
        {
            get { return _patrimonio; }
            set
            {
                _patrimonio = value;
            }
        }
        public String nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int matricula
        {
            get { return _matricula; }
            set
            {
                _matricula = value;
            }
        }
    }
}
