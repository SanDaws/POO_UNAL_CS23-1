/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
//package capitulo_4;
import java.util.Scanner;
public class Ejercicio_22 {
    
    public static void main(String[] args) {
        double salario_mensual;
        String Name;
        double Salario_basico;
        int horas;
        
        Scanner input=new Scanner(System.in);
        
        System.out.println("Ingrese el nombre: ");
        Name=input.nextLine();
        
        System.out.println("Ingrese el Salario basico por hora: ");
        Salario_basico=input.nextDouble();
        
        System.out.println("Ingrese las horas trabajadas al mes: ");
        horas=input.nextInt();
        
        salario_mensual=Salario_basico*horas;
        if (salario_mensual >450000){
                System.out.println("Su nombre es: "+Name+" y su salario mensual es: "+salario_mensual);
            }
        else{
                System.out.println("Su nombre es: "+Name);
            }
        }
 
    }

