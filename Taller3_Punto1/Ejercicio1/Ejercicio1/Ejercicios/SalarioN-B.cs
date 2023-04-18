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
        private string _nombre;
        private double _valhoras, _retencion, _salarioB, _salarioN;
        //constructores
       public SalarioN() { }
       public SalarioN(int codigo,string nombre, int horas, double valhoras, double retencion)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._horas = horas;
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
        public string nombre { get; set; } 
        public int codigo { get; set; }  
        public double valHoras {
            get { return _valhoras; }
            set { _valhoras = value; }
            }
        public double retencion {
            get { return _retencion; }
            set { _retencion  = value; }
        }
        public double salarioB {
            get { return _salarioB; }
            set { _salarioB = value; }
        }  
        public double salarioN {
            get { return _salarioN; }
            set { _salarioN = value; }
        }
        
       //metodos
        public double  calSalarioBase()
        {
            _salarioB = _horas * _valhoras;
            

            return _salarioB;
        }
        public double calSalarioNeto()
        {
            _salarioN = _salarioB *(1-( _retencion/100));
            return _salarioN;
        }
    }
}
