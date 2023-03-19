/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package capitulo_4;

import java.util.Scanner;

public class Ejercicio_23 {
    
    public static void main(String[] args) {
        double A,B,C,Determinante,Valor1_X = 0,Valor2_X = 0;
        
        Scanner Input= new Scanner(System.in);
        
        System.out.println("Ingrese el valor de A: ");
        A= Input.nextDouble();
        
        System.out.println("Ingrese el valor de B: ");
        B= Input.nextDouble();
        
        System.out.println("Ingrese el valor de C: ");
        C= Input.nextDouble();
        
        Determinante=Math.pow(B,2)-(4*A*C);
        
        if (Determinante>0){
                Valor1_X=((B*(-1))+ Math.sqrt(Determinante)) / (2*A);
                Valor2_X=((B*(-1))- Math.sqrt(Determinante)) / (2*A);
                
                System.out.println("Los posibles valores son: "+Valor1_X+" y "+ Valor2_X);
            }
        
        else{
            System.out.println("El determinante es negativo asi que no es posible halla solucion");
        }
        
    
    }
    
}
