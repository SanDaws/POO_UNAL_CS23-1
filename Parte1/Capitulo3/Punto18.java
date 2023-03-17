import java.util.Scanner;
public class Punto18 {
    public static void main(String[] args) {
        int codigo,horas;
        float valhoras,retencion,salarioB,salarioN;
        String nombre;
        Scanner entrada;
        System.out.println("Ingrese el codigo del empleado");
        entrada = new Scanner(System.in);
        codigo=entrada.nextInt();
        System.out.println("Ingrese el nombre del empleado");
        entrada = new Scanner(System.in);
        nombre=entrada.next();
        System.out.println("Ingrese las horas trabajadas");
        entrada = new Scanner(System.in);
        horas=entrada.nextInt();
        System.out.println("Ingrese el valor de la hora trabajada");
        entrada = new Scanner(System.in);
        valhoras=entrada.nextFloat();
        System.out.println("Ingrese el porcentaje de retencion");
        entrada = new Scanner(System.in);
        retencion=entrada.nextFloat();
        salarioB=horas*valhoras;
        salarioN=salarioB-(horas*valhoras*retencion);
        System.out.println("El codigo del empleado es: "+codigo+", el nombre del empleado es: "+nombre);
        System.out.println("El salario bruto es: "+salarioB+", el salario neto es: "+salarioN);
    }   
}
