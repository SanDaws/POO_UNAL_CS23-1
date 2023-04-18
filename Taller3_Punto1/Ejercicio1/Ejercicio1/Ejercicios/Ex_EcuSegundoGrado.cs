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
        private double _A, _B, _C;
        private double _val1, _val2;
        private double _Det;
        public Ex_EcuSegundoGrado() { }
        public Ex_EcuSegundoGrado(Double _A, Double _B, Double _C)
        {
            this._A = _A;
            this._B = _B;
            this._C = _C;
        }
        //mutadores
        public double A
        {
            get { return _A; }
            set { _A = value; }
        }
        public double B
        {
            get { return _B; }
            set { _B = value; }
        }

        public double C {
            get { return _C; }
            set { _C = value; }
        }
        public double Val1 {
            get { return _val1; }
            set { _val1 = value; }
        }
        public double Val2
        {
            get { return _val2; }
            set
            {
                _val2 = value;
            }
        }
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
