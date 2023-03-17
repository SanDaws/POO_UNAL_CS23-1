using System;
namespace ejercicio15
{
    public class esferas{
        public double _peso;
        
        
        public esferas(){}
        public esferas(String peso){ this._peso=double.Parse(peso); }

        public void  pesar(esferas _esA,esferas _esB,esferas _esC,esferas _esD){
            if ((_esA._peso==_esB._peso)&&(_esA._peso==_esC._peso)){  
                Console.WriteLine("LA ESFERA D ES DIFERENTE Y");              
                 if (_esD._peso>_esA._peso)
                 {
                    Console.WriteLine("DE MAYOR PESO");
                 } 
                 else
                 {
                    Console.WriteLine(" DE MENOR PESO");
                 }              
            }
            else
            {
                if ((_esA._peso==_esB._peso)&&(_esA._peso==_esD._peso)){                
                  Console.WriteLine("LA ESFERA C ES DIFERENTE Y");     
                 if (_esC._peso>_esA._peso)
                 {
                    Console.WriteLine("DE MAYOR PESO");
                 } 
                 else
                 {
                    Console.WriteLine(" DE MENOR PESO");
                 }

                  if ((_esA._peso==_esC._peso)&&(_esA._peso==_esD._peso)){                
                  Console.WriteLine("LA ESFERA B ES DIFERENTE Y");     
                 if (_esB._peso>_esA._peso)
                 {
                    Console.WriteLine("DE MAYOR PESO");
                 } 
                 else
                 {
                    Console.WriteLine(" DE MENOR PESO");
                 }
                 
                 
                


                 
            }

            
        }
    }
}
    }
    }