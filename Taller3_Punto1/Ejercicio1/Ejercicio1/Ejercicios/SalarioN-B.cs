using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Ejercicios
{
    public class SalarioN
    {   // ejercicio 18 capitulo 3
        //atributos

        private int _codigo, _horas;
        private double _valhoras, _retencion, _salarioB, _salarioN;
        //constructores
        SalarioN() { }
        SalarioN(int codigo, int horas, double valhoras, double retencion)
        {
            _codigo = codigo;
            _horas = horas;
            this._valhoras = valhoras;
            this._retencion = retencion;
          
        }
        //mutadores
        //uno desde cero
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }

        }
        // version compacta permitida por distribucion .NET
        public int horas { get; set; }
        public double valHoras { get; set; }
        public double retencion { get; set; }
        public double salarioB { get; set; }
        public double salarioN { get; set; } 

        
       //metodos
        public double  calSalarioBase()
        {
            _salarioB = _horas * _valhoras;
            

            return _salarioB;
        }
        public double calSalarioNeto()
        {
            _salarioN = _salarioB - (_horas * _valhoras * _retencion);
            return _salarioN;
        }
    }
}
