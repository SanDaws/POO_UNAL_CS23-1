using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Ejercicios
{
    public class Ex_NumerosIguales
    // ejericio numero 7 capitulo 4
    {
        public Double _NumeroA, _NumeroB;
        //constructores
        public Ex_NumerosIguales() { }
        public Ex_NumerosIguales(Double _numeroA, Double _numeroB) {
            this._NumeroA = _numeroA;
            this._NumeroB = _numeroB;
        }
        //Mutadores
        public Double NumeroA{ get; set; }
        public Double NumeroB { get; set; }


        //metodos
        public String NumeroMIm()
        {
            String _respuesta="numero faltante";
            if ( _NumeroA > _NumeroB)
            {
                _respuesta = "A es mayor que B ";
            }
            if (_NumeroA == _NumeroB)
            {
                _respuesta = "A es igual a B";
            }
            if (_NumeroA < _NumeroB)
            {
                _respuesta = "A es menor que B";
            }
            
            return _respuesta;
        }
        
    }
}
