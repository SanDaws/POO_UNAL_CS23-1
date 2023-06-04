package Tarea4_2;

public class ConjuntoCerrado extends CasaUrbana{
    protected int adminitracion=50000;
    protected int precioventa=2500000;

    public ConjuntoCerrado(int ID,float area,String direccion,String tipoinmueble,int nhabitaciones,int nbaños){
        super(ID, area, direccion, tipoinmueble, nhabitaciones, nbaños);
    }
    

    public void imprimir(){
        super.imprimir();
        precio=adminitracion+super.precioventa(precioventa);
        System.out.println("El inmueble tiene un precio de: "+precio);
        System.out.println("El inmueble tiene un precio de administracion de: "+adminitracion);
        System.out.println("El inmueble incluye zonas comunes");

    }
}
