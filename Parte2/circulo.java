/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ejercicios1semana;
import java.util.Scanner;
/**
 *
 * @author PAULINA HENAO GARCIA
 */
public class circulo {
    public static void main(String[] args){
        System.out.print("Ingrese el radio del circulo:\n");
        Scanner entrada= new Scanner(System.in);
        double radio,area,circunferencia;        
        radio=entrada.nextInt();
        area= Math.PI* Math.pow(radio,2);
        circunferencia=2*Math.PI*radio;
        System.out.println("El area del circulo es: " + area);
        System.out.println("La longitud de la circunferencia: " + circunferencia);        
    } 
}
