package Tarea4_2;

public class Apartaestudio extends Apartamento {
    protected int adminitracion=10000;
    protected int precioventa=1500000;
    
    public Apartaestudio(int ID,float area,String direccion,String tipoinmueble,int nhabitaciones,int nbaños){
        super(ID, area, direccion, tipoinmueble, nhabitaciones, nbaños);
    }

    public void imprimir(){
        super.imprimir();
        precio=adminitracion+super.precioventa(precioventa);
        System.out.println("El inmueble tiene un precio de: "+precio);
        System.out.println("El inmueble tiene un precio de administracion de: "+adminitracion);
    }
    

}
