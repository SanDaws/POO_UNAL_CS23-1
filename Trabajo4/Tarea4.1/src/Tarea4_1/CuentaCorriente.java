package Tarea4_1;

public class CuentaCorriente extends Cuenta {
    float sobregiro;
    
    public CuentaCorriente(float saldo,float tasaAnual){
        super(saldo,tasaAnual);
        sobregiro=0;
    }

    public void retirar(float retirar){
        if (retirar>saldo){
            sobregiro=retirar-saldo;
            saldo=0;
        }
        else{
        super.retirar(retirar);
        }
    }

    public void consignacion(float consignacion){
        float excedente;
        if (sobregiro==0){
            super.consignacion(consignacion);
        }
        else{
            excedente=sobregiro-consignacion;
            if (excedente<0){
                saldo=excedente;
            }    
            else{
                sobregiro-=consignacion;
                saldo=0;
            }
            
        }
    }

    public void extractoMensual(){
        super.extractoMensual();
    }

    public void imprimir(){
        int transacciones= nconsignaciones+nretiros;
        System.out.println("Su saldo eso: "+saldo);
        System.out.println("Su comision mensual: "+comision);
        System.out.println("Numero de transacciones: "+transacciones);
        System.out.println("Sobregiro: "+sobregiro);
    }    
    
}
