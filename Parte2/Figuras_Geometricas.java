/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package figuras_geometricas;

import java.util.Scanner;
public class Figuras_Geometricas {

    public static void main(String[] args) {
        int radio_circulo;//variable para el radio
        int base_rectangulo,altura_rectangulo;//Variables para base y altura del rectangulo.
        int lado_cuadrado;//variable para el cuadrado
        int base_Triangulo_Rectangulo,altura_Triangulo_Rectangulo;//variables para el triangulo rectangulo
        Scanner input=new Scanner(System.in);
        
        //Circulo
        System.out.println("Ingrese el valor del radio:");
        radio_circulo=input.nextInt();
        
        //Rectangulo
        System.out.println("Ingrese el valor de la base y altura del rectangulo respectivamente:");
        base_rectangulo=input.nextInt();
        altura_rectangulo=input.nextInt();
        
        //Cuadrado
        System.out.println("Ingrese el valor del lado del cuadrado:");
        lado_cuadrado=input.nextInt();
        
        //Triangulo Rectangulo
        System.out.println("Ingrese el valor de la base y altura del Triangulo Rectangulo respectivamente:");
        base_Triangulo_Rectangulo=input.nextInt();
        altura_Triangulo_Rectangulo=input.nextInt();
        
        //Objeto
        
        Circulo cr= new Circulo(radio_circulo);
        Rectangulo rt= new Rectangulo(base_rectangulo,altura_rectangulo);
        Cuadrado cd= new Cuadrado(lado_cuadrado);
        Triangulo_Rectangulo Tr= new Triangulo_Rectangulo(base_Triangulo_Rectangulo,altura_Triangulo_Rectangulo);
        System.out.println("El Area del Círculo es: " + (cr.Area()));
        System.out.println("El Perimetro del Círculo es: " + (cr.Perimetro()));
        System.out.println();
        System.out.println("El Area del Rectangulo es: " + (rt.Area()));
        System.out.println("El Perimetro del Rectangulo es: " + (rt.Perimetro()));
        System.out.println();
        System.out.println("El Area del Cuadrado es: " + (cd.Area()));
        System.out.println("El Perimetro del Cuadrado es: " + (cd.Perimetro()));
        System.out.println();
        System.out.println("El Area del Triangulo Rectangulo es: " + (Tr.Area()));
        System.out.println("El Perimetro del Triangulo Rectangulo es: " + (Tr.Perimetro()));
        Tr.Tipo_Triangulo();
        
        
    }
    
}
