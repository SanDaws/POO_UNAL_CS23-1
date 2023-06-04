package Tarea4_1;

public class Cuenta {

    protected float saldo;
    protected int nconsignaciones=0;
    protected int nretiros=0;
    protected float tasaAnual;
    protected float comision=0;

    public Cuenta(float saldo, float tasaAnual) {
        this.saldo=saldo;    
        this.tasaAnual=tasaAnual;
    }

    public void consignacion(float consignacion){
        saldo=saldo+consignacion;
        nconsignaciones+=1;
    }

    public void retirar(float retiro){
        if (retiro<=saldo){
            saldo=saldo-retiro;
            nretiros+=1;
        }
        else{
            System.out.println("Su retiro excede el saldo disponible");
        }
    }

    public void interesMensual(){
        float tasaMensual=tasaAnual/12;
        float interesMensual=saldo*tasaMensual;
        saldo=saldo+interesMensual;
    }

    public void extractoMensual(){
        saldo=saldo-comision;
        interesMensual();
    }

    public void imprimir(){
        System.out.println("Su saldo eso: "+saldo);
        System.out.println("Numero de consignaciones: "+nconsignaciones);
        System.out.println("Numero de retiros: "+nretiros);
        System.out.println("Su tasa anual es: "+tasaAnual);        
    }
}   

