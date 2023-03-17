import java.util.Scanner;
public class Punto19 {
    public static void main(String[] args) {
        double Altura,Area;
        float LadoTrian,Perimetro;
        Scanner entrada;
        entrada=new Scanner(System.in);
        LadoTrian=entrada.nextFloat();
        Perimetro=LadoTrian*3;
        Altura=(Math.pow((LadoTrian),2))-(Math.pow((LadoTrian/2),2));
        Altura=Math.sqrt(Altura);
        Area=(Altura*LadoTrian)/2;
        System.out.println("El perimetro es: "+Perimetro+", la altura es: "+Altura+", el area es: "+ Area);
        entrada.close();
    }
}
