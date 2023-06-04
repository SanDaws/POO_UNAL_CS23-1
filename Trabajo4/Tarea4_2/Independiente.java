package Tarea4_2;

public class Independiente extends CasaUrbana {
    protected int precioventa=3000000;

    public Independiente(int ID,float area,String direccion,String tipoinmueble,int nhabitaciones,int nbaños){
        super(ID, area, direccion, tipoinmueble, nhabitaciones, nbaños);
    }
    
    public void imprimir(){
        super.imprimir();
        System.out.println("El inmueble tiene un precio de: "+super.precioventa(precioventa));
        
    }
}
