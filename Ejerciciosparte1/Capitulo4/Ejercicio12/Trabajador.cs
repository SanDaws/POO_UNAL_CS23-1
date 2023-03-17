using System;
namespace Ejercicio12{
    // hijo: madre /asi se hereda en c#

    class trabajador{
        //atributos
        public String nombre;
        public double horasTrabajadas,pagoHorasBase;
        //metodos
        //constructores
        public trabajador(){}

        public trabajador(String nombre,String horasTrabajadas,String pagoHorasBase){
            this.nombre=nombre;
            this.horasTrabajadas=double.Parse(horasTrabajadas);
            this.pagoHorasBase= double.Parse(pagoHorasBase);
                        
        }
        // como aun no dependo de usar los constructores modificadores (get/set), no vi la necesidad de crearlos
        public double calcularPago(){
            double horasExtras,_horasTriples;// resultante de restas
            double _salario=0;
            if (horasTrabajadas> 40){
                horasExtras=horasTrabajadas-40;
                if (horasExtras>8){
                    _horasTriples=horasExtras-8;
                    _salario= (40*pagoHorasBase)+(16*pagoHorasBase)+(_horasTriples*3)*pagoHorasBase;                
                }
                else{
                    _salario= (40*pagoHorasBase)+(2*horasExtras)*pagoHorasBase;
                }
            }
            else{
                _salario=horasTrabajadas*pagoHorasBase;
            }
            return _salario;

        }

        public void presentarSueldo(double _salario){
            Console.WriteLine($"EL TRABAJADOR {nombre} DEVENGO: ${_salario}");
        }
    }
}