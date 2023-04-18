using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio1.Ejercicios
{   // cap4 ejercico 23
    internal class Ex_hora_laboral
    {
        private double _salariBase, _salarioMensual, _hora;
        private String _nombre,_respuesta;

        public Ex_hora_laboral() { }
        // no creo las otras opciones de constructor parametrizado porque para los ejercicios no los necesito

        public double salarioBase {
            get { return _salariBase; }
            set { _salariBase = value; }
        }
        public double salarioMensual
        {
            get { return _salarioMensual; }
            set { _salarioMensual = value; }

        }
        public double horas {
            get { return _hora;
            }
            set { _hora = value;
            }
        }
        public String Nombre{
        get { return _nombre;}
            set
            {
                _nombre = value;
            }   
        }


        //metodos
        public String Calcsalario()
        {
            _salarioMensual = _salariBase * _hora;

            if (_salarioMensual > 450000)
            {
                _respuesta = $"{_nombre}:{_salarioMensual}";
                return _respuesta;
            }
            else
            {
                _respuesta = $"{_nombre}:Salario menor a $450.000 ";
                return _respuesta;
            }

           
        }

    }
}
