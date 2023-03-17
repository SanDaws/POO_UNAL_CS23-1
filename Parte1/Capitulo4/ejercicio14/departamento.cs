using System;
namespace ejercicio14
{
    public class departamento
    {
      public double _ventasDepartamentos;
        public double aumento=0.2;
        public  departamento(){}
        
        public departamento(String ventas){
            _ventasDepartamentos=double.Parse(ventas);
        }

        


    }

}