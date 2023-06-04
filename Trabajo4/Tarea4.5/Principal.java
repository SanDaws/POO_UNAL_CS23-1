
package Personas;

/**
* Esta clase define el punto de ingreso al programa de gestión de
* personas.
* Por lo tanto, cuenta con un método main de acceso al programa.
*/
public class Principal {
    /**
    * Método main que sirve de punto de entrada al programa
    */
    public static void main(String[] args) {
        MainWindow miVentanaPrincipal; /* Define la ventana
        principal */
        miVentanaPrincipal = new MainWindow(); /* Crea la ventana
        principal */
        miVentanaPrincipal.setVisible(true); /* Establece la ventana
        como visible */
    }
}
