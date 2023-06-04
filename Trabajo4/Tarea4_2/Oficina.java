package Tarea4_2;

public class Oficina extends Locales{
    protected boolean gobierno;
    protected float precioventa=3500000;
    public Oficina(int ID,float area,String direccion,String tipoinmueble,String localizacion,boolean gobierno){
        super(ID, area, direccion, tipoinmueble, localizacion);
        this.gobierno=gobierno;
    }
    
    public void imprimir(){
        super.imprimir();
        System.out.println("El inmueble tiene un precio de: "+super.precioventa(precioventa));
        if (gobierno==true){
        System.out.println("El inmueble es del gobierno");
        }
        else if (gobierno==false){
            System.out.println("El inmueble no es del gobierno");
        }
       
    }
}
