package Tarea4_2;

public class Locales extends Inmuebles {
    protected String localizacion;
    public Locales(int ID,float area,String direccion,String tipoinmueble,String localizacion){
        super(ID, area, direccion, tipoinmueble);
        this.localizacion=localizacion;
    }

    public void imprimir(){
        super.imprimir();
        System.out.println("La localizacion del inmueble es: "+localizacion);
    }
    
}
