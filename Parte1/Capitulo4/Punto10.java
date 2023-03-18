import java.util.Scanner;
public class Punto10 {
    public static void main(String[] args) {
        int numinscripcion,estrato;
        String nombre;
        float patrimonio,matricula;
        Scanner entrada;
        System.out.println("Ingrese su numero de inscripcion");
        entrada = new Scanner(System.in);
        numinscripcion=entrada.nextInt();
        System.out.println("Ingrese su nombre de inscripcion");
        entrada = new Scanner(System.in);
        nombre=entrada.next();
        System.out.println("Ingrese su patrimonio de inscripcion");
        entrada = new Scanner(System.in);
        patrimonio=entrada.nextFloat();
        System.out.println("Ingrese su estrato de inscripcion");
        entrada = new Scanner(System.in);
        estrato=entrada.nextInt();
        if (patrimonio>2000000 && estrato>3){
            matricula=50000+((patrimonio*3)/100);
            System.out.println("El numero de inscripcion es "+numinscripcion+" el nombre del estudiante es "+nombre+" y el valor de matricula es "+matricula);
        } else{
            matricula=50000;
            System.out.println("El numero de inscripcion es "+numinscripcion+" el nombre del estudiante es "+nombre+" y el valor de matricula es "+matricula);
        }

    }
}
