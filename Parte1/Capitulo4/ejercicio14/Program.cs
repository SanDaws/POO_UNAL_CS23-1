namespace ejercicio14;
class Program
{
    static void Main(string[] args)
    {
        String ventaDep1,ventaDep2,ventaDep3,Salario;

        Console.Write("Ventas departamento 1: ");
        ventaDep1=Console.ReadLine();
        Console.Write("Ventas departamento 2: ");
        ventaDep2=Console.ReadLine();
        Console.Write("Ventas departamento 3: ");
        ventaDep3=Console.ReadLine();
        Console.Write("Salario base de los Vendedores: ");
        Salario=Console.ReadLine();

        //Sales departament(SD), para haceme mas corta la codificacion
        departamento _SD1= new departamento(ventaDep1);
        departamento _SD2= new departamento(ventaDep2);
        departamento _SD3= new departamento(ventaDep3);
        //sales mans(SM)
        vendedores SM1=new vendedores(Salario,_SD1);
        vendedores SM2=new vendedores(Salario,_SD2);
        vendedores SM3=new vendedores(Salario,_SD3);

        // Generamos el total de las ventas
        double totVentas= _SD1._ventasDepartamentos+_SD2._ventasDepartamentos+_SD3._ventasDepartamentos;
        // hacemos el paso por el condicional
        SM1.venDep(totVentas);
        SM2.venDep(totVentas);
        SM3.venDep(totVentas);

        // me hubiera gustado que pudierna tener nombres o numeracion los departamentos asi hacerlo todo dentro de otra clase
        Console.WriteLine($"SALARIO VENDEDORES DEPTO.1: {SM1._pagoFinal}");
        Console.WriteLine($"SALARIO VENDEDORES DEPTO.2: {SM2._pagoFinal}");
        Console.WriteLine($"SALARIO VENDEDORES DEPTO.3: {SM3._pagoFinal}");
    }
}
