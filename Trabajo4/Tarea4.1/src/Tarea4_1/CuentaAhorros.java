package Tarea4_1;

public class CuentaAhorros extends Cuenta{
    private boolean activa;

    public CuentaAhorros(float saldo,float tasaAnual){
        super(saldo, tasaAnual);
        if (saldo<10000){
            activa=false;
        }
        else{
            activa=true;    
        }
    }

    public void retirar(float retiro){
        if (activa=true){
            super.retirar(retiro);
        }
    }

    public void consignacion(float consignacion){
        if (activa=true){
            super.consignacion(consignacion);
        }
    }

    public void extractoMensual(){
        if (activa=true){
            if (nretiros>4){
                comision=comision+(nretiros-4)*1000;
            }
            super.extractoMensual();
            if (saldo<10000){
                activa=false;
            }
        }      
    }
    public void imprimir(){
        int transacciones= nconsignaciones+nretiros;
        System.out.println("Su saldo eso: "+saldo);
        System.out.println("Su comision mensual: "+comision);
        System.out.println("Numero de transacciones: "+transacciones);
    }    
}
