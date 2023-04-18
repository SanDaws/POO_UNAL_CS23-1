using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Ejercicios
{
    internal class Ex_Matricula_Estudiantil
    {
        private int _numInsc, _estrato;
        private String _nombre, _respuesta;
        private float _patrimonio, _matricula;


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
        public float matricula
        {
            get { return _matricula; }
            set
            {
                _matricula = value;
            }
        }


        public String CalcMatricula() {
            if (_patrimonio > 2000000 && _estrato > 3)
            {
                _matricula = 50000 + ((_patrimonio * 3) / 100);
                _respuesta = ($"El numero de inscripcion es  { _numInsc },  el nombre del estudiante es {_nombre}  y el valor de matricula es {matricula}" );
            }
            else
            {
                matricula = 50000;
                _respuesta = ($"El numero de inscripcion es  {_numInsc},  el nombre del estudiante es {_nombre}  y el valor de matricula es {matricula}");
            }
            return _respuesta;
        }
    }
}
