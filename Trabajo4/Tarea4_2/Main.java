package Tarea4_2;
import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        System.out.println("Ingrese el numero del inmueble que desea: \n 1.Casa rural \n 2.Casa conjunto cerrado \n 3.Casa independiente \n 4.Apartamento Familiar \n 5.Apartaestudio \n 6.Locales Comerciales \n 7.Oficinas");
        int tipo = entrada.nextInt();
        if (tipo==1){
            String tipoinmueble="Casa rural";
            System.out.println("Ingrese la identificacion del inmueble");
            int ID = entrada.nextInt();
            System.out.println("Ingrese la area del inmueble");
            float area = entrada.nextFloat();
            System.out.println("Ingrese la direccion del inmueble");
            String direccion = entrada.next();
            System.out.println("Ingrese el numero de habitaciones del inmueble");
            int nhabitaciones = entrada.nextInt();
            System.out.println("Ingrese el numero de baños del inmueble");
            int nbaños = entrada.nextInt();
            System.out.println("Ingrese el numero de pisos del inmueble");
            int npisos = entrada.nextInt();
            System.out.println("Ingrese la altitud del inmueble");
            float altitud = entrada.nextFloat();
            System.out.println("Ingrese la distancia del cabecera municipal del inmueble");
            float distanciapueblo = entrada.nextFloat();
            Inmuebles CasaRural1 = new CasaRural(ID, area, direccion, tipoinmueble ,nhabitaciones, nbaños, npisos, altitud, distanciapueblo);
            CasaRural1.imprimir();
        }
        else if (tipo==2){
            String tipoinmueble="Conjunto cerrado";
            System.out.println("Ingrese la identificacion del inmueble");
            int ID = entrada.nextInt();
            System.out.println("Ingrese la area del inmueble");
            float area = entrada.nextFloat();
            System.out.println("Ingrese la direccion del inmueble");
            String direccion = entrada.next();
            System.out.println("Ingrese el numero de habitaciones del inmueble");
            int nhabitaciones = entrada.nextInt();
            System.out.println("Ingrese el numero de baños del inmueble");
            int nbaños = entrada.nextInt();
            Inmuebles ConjuntoCerrado1 = new ConjuntoCerrado(ID, area, direccion, tipoinmueble, nhabitaciones, nbaños);
            ConjuntoCerrado1.imprimir();
        }
        else if (tipo==3){
            String tipoinmueble="Casa Independiente";
            System.out.println("Ingrese la identificacion del inmueble");
            int ID = entrada.nextInt();
            System.out.println("Ingrese la area del inmueble");
            float area = entrada.nextFloat();
            System.out.println("Ingrese la direccion del inmueble");
            String direccion = entrada.next();
            System.out.println("Ingrese el numero de habitaciones del inmueble");
            int nhabitaciones = entrada.nextInt();
            System.out.println("Ingrese el numero de baños del inmueble");
            int nbaños = entrada.nextInt();
            Inmuebles ConjuntoCerrado1 = new Independiente(ID, area, direccion, tipoinmueble, nhabitaciones, nbaños);
            ConjuntoCerrado1.imprimir();
        }
        else if (tipo==4){
            String tipoinmueble="Apartamento Familiar";
            System.out.println("Ingrese la identificacion del inmueble");
            int ID = entrada.nextInt();
            System.out.println("Ingrese la area del inmueble");
            float area = entrada.nextFloat();
            System.out.println("Ingrese la direccion del inmueble");
            String direccion = entrada.next();
            System.out.println("Ingrese el numero de habitaciones del inmueble");
            int nhabitaciones = entrada.nextInt();
            System.out.println("Ingrese el numero de baños del inmueble");
            int nbaños = entrada.nextInt();
            Inmuebles ApartamentoFamiliar1 = new ApartamentoFamiliar(ID, area, direccion, tipoinmueble, nhabitaciones, nbaños);
            ApartamentoFamiliar1.imprimir();
        }
        else if (tipo==5){
            String tipoinmueble="Apartaestudio";
            int nhabitaciones=1;
            System.out.println("Ingrese la identificacion del inmueble");
            int ID = entrada.nextInt();
            System.out.println("Ingrese la area del inmueble");
            float area = entrada.nextFloat();
            System.out.println("Ingrese la direccion del inmueble");
            String direccion = entrada.next();
            System.out.println("Ingrese el numero de baños del inmueble");
            int nbaños = entrada.nextInt();
            Inmuebles Apartaestudio1 = new Apartaestudio(ID, area, direccion, tipoinmueble, nhabitaciones, nbaños);
            Apartaestudio1.imprimir();
            
        }
        else if (tipo==6){
            String tipoinmueble="Locales Comerciales";
            System.out.println("Ingrese la identificacion del inmueble");
            int ID = entrada.nextInt();
            System.out.println("Ingrese la area del inmueble");
            float area = entrada.nextFloat();
            System.out.println("Ingrese la direccion del inmueble");
            String direccion = entrada.next();
            System.out.println("El inmueble se ubica dentro o da a la calle del centro comercial");
            String localizacion = entrada.next();
            System.out.println("Ingrese el nombre del centro comercial donde se encuentra ubicado el inmueble");
            String centrocomercial = entrada.next();
            Inmuebles LocalesComerciales1 = new LocalesComerciales(ID, area, direccion, tipoinmueble, localizacion, centrocomercial);
            LocalesComerciales1.imprimir();
            
        }
        else if (tipo==7){
            String tipoinmueble="Oficina";
            System.out.println("Ingrese la identificacion del inmueble");
            int ID = entrada.nextInt();
            System.out.println("Ingrese la area del inmueble");
            float area = entrada.nextFloat();
            System.out.println("Ingrese la direccion del inmueble");
            String direccion = entrada.next();
            System.out.println("El inmueble se ubica dentro o da a la calle del centro comercial");
            String localizacion = entrada.next();
            System.out.println("La oficina es del gobierno \n 1.Si \n 2.No");
            int gobierno = entrada.nextInt();
            if (gobierno==2){
                Inmuebles oficina1 = new Oficina(ID, area, direccion, tipoinmueble, localizacion,false);
                oficina1.imprimir();
            }
            else if (gobierno==1){
                Inmuebles oficina1 = new Oficina(ID, area, direccion, tipoinmueble, localizacion,true);
                oficina1.imprimir();
            }
            
            
        }
    }
}
