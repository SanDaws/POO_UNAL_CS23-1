package Tarea4_2;

public class Inmuebles {
    protected int ID;
    protected float area;
    protected String direccion;
    protected float precio;
    protected String tipoinmueble;

    public Inmuebles(int ID,float area,String direccion,String tipoinmueble){
        this.ID=ID;
        this.area=area;
        this.direccion=direccion;
        this.tipoinmueble=tipoinmueble;
    }

    public float precioventa(float valorarea){
        precio=valorarea*area;
        return precio;
    }

    public void imprimir(){
        System.out.println("Identificador de inmueble: "+ID);
        System.out.println("Area de inmueble: "+area);
        System.out.println("Direccion inmueble: "+direccion);
        System.out.println("Tipo de inmueble "+tipoinmueble);
    }



}
