using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Ejercicios
{
    public class Ex_NumerosIguales
    // ejericio numero 7 capitulo 4
    {
        private double _NumeroA, _NumeroB;
        private String _respuesta;
        //constructores
        public Ex_NumerosIguales() { }
        public Ex_NumerosIguales(int _numeroA, int _numeroB) {
            this._NumeroA = _numeroA;
            this._NumeroB = _numeroB;
        }
        //Mutadores
        public double NumeroA
        {
            get { return _NumeroA; }
            set { _NumeroA = value; }
        }
        public double NumeroB
        {
            get { return _NumeroB; }
            set { _NumeroB = value; }
        }
        public String respuesta { get; set; }


        //metodos
        public String NumeroMIm()
        {
            
           if (_NumeroA>_NumeroB)
            {
                return _respuesta = "A es mayor que B ";
            }
           else if (_NumeroA == _NumeroB)
            {
               return _respuesta = "A es igual a B";
            }
           else if (_NumeroA < _NumeroB)
            {
                return  _respuesta = "A es menor que B";
            }
           else
            {
             return _respuesta;
            }
           
        }
        
    }
}
