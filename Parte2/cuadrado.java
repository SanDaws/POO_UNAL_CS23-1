/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ejercicios1semana;
import java.util.Scanner;

public class cuadrado {
    public static void main(String[]args){
        System.out.println("Ingrese un numero:");
        Scanner entrada=new Scanner(System.in);
        double numero,cuadrado,cubo;
        numero=entrada.nextInt();
        cuadrado=Math.pow(numero, 2);
        cubo=Math.pow(numero,3);
        System.out.println("El cuadrado del numero es:" + cuadrado);
        System.out.println("El cubo del numero es:" + cubo);
    }
}
