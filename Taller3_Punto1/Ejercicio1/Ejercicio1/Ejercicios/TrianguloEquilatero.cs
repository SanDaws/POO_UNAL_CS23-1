using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Ejercicios
{       //ejercicio 19 del capitulo 3
    internal class TrianguloEquilatero
    {   //atributos
        public float _ladoTriangulo;
        private float _perimetro;
        private double _altura, _Area;
        //constructores
        public TrianguloEquilatero() { }
        public TrianguloEquilatero(float ladoTriangulo)
        {
            _ladoTriangulo = ladoTriangulo;
        }
        //mutadores
        public float perimetro { get; set; }
        public double altura { get; set; }   
        public double area { get; set; }


        //metodos
        public float Perimetro()
        {
            _perimetro= _ladoTriangulo*3;
            return _perimetro;
        }
        public double Altura()
        {
            _altura= (Math.Pow((_ladoTriangulo), 2)) - (Math.Pow((_ladoTriangulo / 2), 2));
            _altura = Math.Sqrt(_altura);
            return _altura;
        }
        public double Area()
        {
            _Area = (Altura() * _ladoTriangulo) / 2;
            return _Area;
        }

    }
}
