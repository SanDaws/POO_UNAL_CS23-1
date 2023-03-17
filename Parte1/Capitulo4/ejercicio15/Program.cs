namespace ejercicio15;
class Program
{
    /*
    !n = ~n
    or |  el lento/ || el rapido si der. true, no evalua izq
    and & el y de toda la vida /  && solo evalua el de la de, si es falso todo es falso
    exclusive or ^ : solo verdadero si uno de los dos es falso y el otro no
    */
    static void Main(string[] args)
    {
        /*profe, le juro que no tengo nada en contra de usar int, solo que como los pesos pueden ser 
           con decimales, y la mayoria de ejercicios pueden romperse si pongo solo int
           preferi usar un poco mas de memoria reservada, por si acaso */
           String _BolaA,_BolaB,_BolaC,_BolaD;
           Console.Write("peso de la esfera A");
           _BolaA=Console.ReadLine();
           Console.Write("peso de la esfera B");
           _BolaB=Console.ReadLine();
           Console.Write("peso de la esfera C");
           _BolaC=Console.ReadLine();
           Console.Write("peso de la esfera D");
           _BolaD=Console.ReadLine();
        esferas _es1= new esferas(_BolaA);
        esferas _es2= new esferas(_BolaA);
        esferas _es3= new esferas(_BolaA);
        esferas _es4= new esferas(_BolaA);

        _es1.pesar(_es1,_es2,_es3,_es4);
}
