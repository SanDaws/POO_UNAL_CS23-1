package Tarea4_2;

public class LocalesComerciales extends Locales {
    protected String centrocomercial;
    protected float precioventa=3000000;
    public LocalesComerciales(int ID,float area,String direccion,String tipoinmueble,String localizacion,String CentroComercial){
        super(ID, area, direccion, tipoinmueble, localizacion);
        this.centrocomercial=CentroComercial;
    }
    
    public void imprimir(){
        super.imprimir();
        System.out.println("El inmueble tiene un precio de: "+super.precioventa(precioventa));
        System.out.println("El inmueble esta establecido en el centro comercial:" + centrocomercial);
    }
}
