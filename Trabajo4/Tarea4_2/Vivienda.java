package Tarea4_2;

public class Vivienda extends Inmuebles{
    protected int nhabitaciones;
    protected int nbaños;
    
    public Vivienda(int ID,float area,String direccion,String tipoinmueble,int nhabitaciones,int nbaños){
        super(ID, area, direccion, tipoinmueble);
        this.nbaños=nbaños;
        this.nhabitaciones=nhabitaciones;
    }
    
    public void imprimir(){
        super.imprimir();
        System.out.println("El numero de habitaciones del inmueble son: "+nhabitaciones);
        System.out.println("El numero de baños del inmueble son: "+nbaños);
    }
    
}
