/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package figuras_geometricas;

public class Triangulo_Rectangulo {
    //Atributos
    int base;
    int altura;
    public Triangulo_Rectangulo(int base,int altura){
        this.base=base;
        this.altura=altura;
    }
    public double Area(){
        return (base*altura /2);
    }
    public double Hipotenusa(){
        return Math.sqrt(base*base+altura*altura);
    }
    public double Perimetro(){
        
        return (base+altura+Hipotenusa());
    }
    public void Tipo_Triangulo(){
        if((base==altura)&&(base==Hipotenusa())&&(Hipotenusa()==altura))
            System.out.println("Es un triangulo equilatero");
        else if((base!=altura)&&(base!=Hipotenusa())&&(Hipotenusa()!=altura))
            System.out.println("Es un triangulo Escaleno");
        else
            System.out.println("Es un triangulo Isosceles");
    }

    }
    
