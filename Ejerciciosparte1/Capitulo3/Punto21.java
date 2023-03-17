import java.util.Scanner;
public class App {
    public static void main(String[] args) {
        double lado1,lado2,lado3,perimetro,semiperimetro,area;
        Scanner entrada;
        System.out.println("Ingrese el primer lado del triangulo");
        entrada= new Scanner(System.in);
        lado1=entrada.nextDouble();
        System.out.println("Ingrese el segundo lado del triangulo");
        entrada= new Scanner(System.in);
        lado2=entrada.nextDouble();
        System.out.println("Ingrese el tercer lado del triangulo");
        entrada= new Scanner(System.in);
        lado3=entrada.nextDouble();
        perimetro=lado1+lado2+lado3;  
        semiperimetro=perimetro/2;
        area=Math.sqrt(semiperimetro*((semiperimetro-lado1)*(semiperimetro-lado2)*(semiperimetro-lado3)));
        System.out.println("El perimetro es: "+ perimetro+", el semiperimetro es: "+semiperimetro+", el area es: "+area);    
    }
}
