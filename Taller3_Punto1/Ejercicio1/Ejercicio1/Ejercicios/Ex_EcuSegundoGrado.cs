using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Ejercicios
{   // ejercicio  22 capitulo4
    internal class Ex_EcuSegundoGrado
    {
        //ejercicio 22 capitulo4
        Double _A, _B, _C;
        Double _val1, _val2;
        Double _Det;
        public Ex_EcuSegundoGrado() { }
        public Ex_EcuSegundoGrado(Double _A, Double _B, Double _C)
        {
            this._A = _A;
            this._B = _B;
            this._C = _C;
        }
        //mutadores
        public Double A
        {
            get { return _A; }
            set { _A = value; }
        }
        public Double B { get; set; }
        public Double C { get; set; }
        public double Val1 { get; set; }
        public double Val2 { get; set; }
        //metodos
        public void determinante()
        {
            _Det = Math.Pow(_B, 2) - (4 * _A * _C);
        }
        public void ecuacion()
        {
            if (_Det > 0)
            {
                _val1 = ((_B * (-1)) + Math.Sqrt(_Det)) / (2 * A);
                _val2 = ((_B * (-1)) - Math.Sqrt(_Det)) / (2 * A);
            }
            else
            {
                _val1 = 0;
                _val2 = 0;
            }
        }

    }
}
