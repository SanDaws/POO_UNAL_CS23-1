package Tarea4_2;

public class ApartamentoFamiliar extends Apartamento{
    protected int adminitracion=25000;
    protected int precioventa=2000000;

    public ApartamentoFamiliar(int ID,float area,String direccion,String tipoinmueble,int nhabitaciones,int nbaños){
        super(ID, area, direccion, tipoinmueble, nhabitaciones, nbaños);
    }

    public void imprimir(){
        super.imprimir();
        precio=adminitracion+super.precioventa(precioventa);
        System.out.println("El inmueble tiene un precio de: "+precio);
        System.out.println("El inmueble tiene un precio de administracion de: "+adminitracion);
    }
    
}
