using System;

// estos son diferentes nombres de espacio(namespace), que necesitare, por eso, lo importamos

//asembly(DLL o EXE): une todos los espacios de trabajo
//Dll(dinamic link library
namespace EjerciciosWeck1
{
    

    internal class Program      // el conjunto de muchas clase hace que el porgrmaa tenga funcionalidad
        //data== atributos
        //funciones == metodods
    {
        static void Main(string[] args)
        {
            String menu= "Bienvenido, Opciones:\nEjercicio1: eddad madre de juan \nEjercicio2: suma \nEjercicio3: salario base\nEjercicio4: circunferencia\nEjercicio5: Cubo y cuadrado de un numero\nSalir: q";
            char direcctor ='0';// llevara a la direccion indicada
            while (direcctor != 'q')
            {
                
                Console.WriteLine(menu);
                Console.Write("Indique el ejercicio que desea revisar:");
                direcctor=char.Parse(Console.ReadLine());
                if (direcctor=='1') {
                    madre luismom= new  madre();
                    madre.mama(Console.ReadLine());

                    }
                else if (direcctor=='2') sumaTecnica();
                else if (direcctor=='3') Salario();
                else if (direcctor=='4') Circunferencia();
                else if (direcctor=='5') CuadraCubo();
                
                
            }


        }
        
        

        //suma programada
        static void sumaTecnica() {
            //
            int suma = 0;
            int x = 20;
            suma = suma + x;// Output: 20
            int y = 40;
            x = x + (int)Math.Pow(y, 2);// Output: x= 1620
            suma = suma + x / y;    //Output: 60
            Console.WriteLine("EL VALOR DE LA SUMA ES:" + suma);
            //EL VALOR DE LA SUMA ES 60

        }

        //erecicio de salario base de un trabajador       
        static void Salario(){
            int  horasTrabajadas=48;
            const int HoraLaboral = 5000;
            double Retencion= 0.125; // 12.5%= 0.125
            //salario bruto
            double SalarioBruto= HoraLaboral*horasTrabajadas;
            Console.WriteLine("salario Bruto: "+ SalarioBruto);
            Retencion=Retencion*SalarioBruto;
            Console.WriteLine($"Retencion(12.5%): {Retencion}");
            double salarioNeto=SalarioBruto-Retencion;
            Console.WriteLine("Salario neto: "+ salarioNeto);

        }
        // ejercicio circunferencia basada en un punto
        static void Circunferencia(){
            /*
            circunferencia= 2* pi * r
            area= pi*rad^2 
            */
            double radio= double.Parse(Console.ReadLine());
            double circunferencia= 2*Math.PI*radio;
            double area= Math.PI*(Math.Pow(radio,2));
            Console.WriteLine($"Longitud de la Circunferencia: {circunferencia} /n Area del circulo: {area}");
        }

        //basado en un numero obtener su cuadrado y su cubo
        static void CuadraCubo(){
            String numero= Console.ReadLine();
            double numeros=double.Parse(numero);
            Console.WriteLine("El cuadrado del numero es: "+ Math.Pow(numeros,2));
            Console.WriteLine("El cubo del numero es: "+ Math.Pow(numeros,3));

        }





    }
}