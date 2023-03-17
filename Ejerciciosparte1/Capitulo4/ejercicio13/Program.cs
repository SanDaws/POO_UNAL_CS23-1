namespace ejercicio13;
class Program
{
    static void Main(string[] args)
    {
        String precio,bolita;
        Console.Write("valor de la compra: ");
        precio=Console.ReadLine();
        Console.Write("color de la bola: ");
        bolita=Console.ReadLine();
       Compra compra0= new Compra(precio,bolita);
       compra0.recibo(compra0.sorteo());

    }
}
