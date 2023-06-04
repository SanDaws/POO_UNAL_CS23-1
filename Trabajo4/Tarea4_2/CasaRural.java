package Tarea4_2;

public class CasaRural extends Vivienda {
    protected int npisos;
    protected float altitud;
    protected float distanciapueblo;
    protected int precioventa=1500000;

    public CasaRural(int ID,float area,String direccion,String tipoinmueble,int nhabitaciones,int nbaños,int npisos,float altitud, float distanciapueblo){
        super(ID, area, direccion, tipoinmueble, nhabitaciones, nbaños);
        this.npisos=npisos;
        this.altitud=altitud;
        this.distanciapueblo=distanciapueblo;
    }

    public void imprimir(){
        super.imprimir();
        System.out.println("El numero de pisos del inmueble es: "+npisos);
        System.out.println("La altitud del inmueblbe es: "+ altitud);
        System.out.println("El inmueble esta a una distancia de la cabecera municipal: "+ distanciapueblo);
        System.out.println("El inmueble tiene un precio de: "+super.precioventa(precioventa));
    }
}
