using System;
namespace ejercicio14
{
    public class vendedores
    {
        public double _salarioVendedores,_pagoFinal;
        public departamento _depAsignado;
        


        public vendedores(){}
        public vendedores(String _salarioVendedores, departamento depAsignado){
            this._salarioVendedores=double.Parse(_salarioVendedores);
            this._depAsignado=depAsignado;
        }
        public void venDep(double totVentas){//
            double  porcentaje= 0.33*totVentas;
            if (_depAsignado._ventasDepartamentos>porcentaje)
            {
                _pagoFinal=_salarioVendedores+(_depAsignado.aumento*_salarioVendedores);
            }

        }


    }
}