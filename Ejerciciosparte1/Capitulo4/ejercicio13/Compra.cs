using System;
namespace ejercicio13{
    class Compra{
        public double _precio,_valorPagar;
        public String _colorBolita;
        

        public Compra(){}

        public Compra(String precio, String bolita){
            _precio=double.Parse(precio);
            _colorBolita=bolita;
        }

        public int sorteo(){
            int descuento=0;
            //if (_colorBolita.ToUpper()=="BLANCO")
            _colorBolita.ToUpper();
            switch (_colorBolita){
                case "BLANCO":descuento=0;
                break;
                case "VERDE":descuento=10;
                break;
                case "AMARILLO":descuento=25;
                break;
                case "AZUL":descuento=50;
                break;
                default: descuento=100;
                break;
            }
        return descuento;          
        }
        public void recibo(int descuento){
            _valorPagar=_precio-((descuento*_precio)/100);


        }


    }
}