import java.util.Scanner;
public class punto7 {
    public static void main(String[] args) {
        float A,B;
        Scanner entrada;
        System.out.println("Ingrese el valor de A");
        entrada= new Scanner(System.in);
        A=entrada.nextFloat();
        System.out.println("Ingrese el valro de B");
        entrada= new Scanner(System.in);
        B=entrada.nextFloat();
        if (A>B){
            System.out.println("A es mayor que B ");
        } 
        if (A==B){
            System.out.println("A es igual a B");
        } 
        if (A<B){
            System.out.println("A es menor que B");
        }
    }
}
