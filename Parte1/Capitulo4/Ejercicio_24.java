/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package capitulo_4;

import java.util.Scanner;

public class Ejercicio_24 {
    
   public static void main(String[] args) {
        double Esfera_A,Esfera_B,Esfera_C;
        
        Scanner input=new Scanner(System.in);
        
        System.out.println("Ingrese el peso de la esfera A");
        Esfera_A=input.nextDouble();
        
        System.out.println("Ingrese el peso de la esfera B");
        Esfera_B=input.nextDouble();
        
        System.out.println("Ingrese el peso de la esfera C");
        Esfera_C=input.nextDouble();
        
        if (Esfera_A>Esfera_B && Esfera_A>Esfera_C){
            System.out.println("La esfera A es la de mayor peso");
        }
        
        else if (Esfera_B>Esfera_A && Esfera_B>Esfera_C){
            System.out.println("La esfera B es la de mayor peso");
        }
        else{
            System.out.println("La esfera C es la de mayor peso");
        }
    
    } 
    
}
