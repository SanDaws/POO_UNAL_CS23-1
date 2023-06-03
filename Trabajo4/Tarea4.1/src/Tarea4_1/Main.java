package Tarea4_1;
import java.util.Scanner;
public class Main {
    public static void main(String args[]) {
        Scanner entrada = new Scanner(System.in);
        System.out.println("Cuenta de ahorros");
        System.out.println("Ingrese saldo inicial");
        float saldo = entrada.nextFloat();
        System.out.print("Ingrese tasa de interés= ");
        float tasaAnual = entrada.nextFloat();
        CuentaAhorros cuenta1 = new CuentaAhorros(saldo, tasaAnual);
        System.out.print("Ingresar cantidad a consignar: $");
        float Deposito = entrada.nextFloat();
        cuenta1.consignacion(Deposito);
        System.out.print("Ingresar cantidad a retirar: $");
        float cantidadRetirar = entrada.nextFloat();
        cuenta1.retirar(cantidadRetirar);
        cuenta1.extractoMensual();
        cuenta1.imprimir();
        entrada.close();
    }
}
