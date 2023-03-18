import java.util.Scanner;
public class punto11 {
    public static void main(String[] args) {
        int A,B,C;
        Scanner entrada;
        System.out.println("Ingrese el primer numero");
        entrada=new Scanner(System.in);
        A=entrada.nextInt();
        System.out.println("Ingrese el segundo numero");
        entrada=new Scanner(System.in);
        B=entrada.nextInt();
        System.out.println("Ingrese el tercer numero");
        entrada=new Scanner(System.in);
        C=entrada.nextInt();
        if (A>B && A>C){
            System.out.println("El numero "+A+" es el mas grande");
        }
        if (B>A && B>C) {
            System.out.println("El numero "+B+" es el mas grande");
        }  
        if (C>A && C>B) {
            System.out.println("El numero "+C+" es el mas grande");
        }  
    }
}
