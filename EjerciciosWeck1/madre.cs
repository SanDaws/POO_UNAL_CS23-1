using System;
 namespace EjerciciosWeck1
 {
    class madre{
            int edadJuan ; 
        public static void mama(String edad) {
            //recibir la edad de juan
            int edadJuan = int.Parse(edad); 
            /* La alerta que se presenta en esta y lineas similare
            resulta darse por motivo del posible error de que un usuario 
            no inserte nada, devolviendo valor NULL,
            Atento a cambios para mejorarla
            */
            int edadAlberto =  2*edadJuan / 3;
            int edadAna = 3*edadJuan / 4;
            int edadMadre = edadJuan + edadAlberto + edadAna;


            //impresion de resultados
            Console.WriteLine($"Alberto: {edadAlberto}");
            Console.WriteLine("Ana: " + edadAna);
            Console.WriteLine("madre: " + edadMadre);
        }
    }
      
 }