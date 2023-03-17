namespace Ejercicio12;
class Program
{
    static void Main(string[] args)
    {
        // recepcion de datos de le mpleado
        //nombre
        Console.Write("Nombre del Empleado");
        String _nom=Console.ReadLine();
// horas trabajadas
        Console.Write("Horas de trabajo del Empleado");
        String _nht=Console.ReadLine();
//Pago por hora base
        Console.Write("Precio de hora Trabajada");
        String _vhn=Console.ReadLine();
        //creamos el objeto
        
       trabajador trabajador1= new trabajador(_nom,_nht,_vhn);
       
       trabajador1.presentarSueldo(trabajador1.calcularPago());
        
    }
}
