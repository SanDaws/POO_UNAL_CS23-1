
package Personas;

import java.util.*;

/**
* Esta clase denominada ListaPersonas define un vector de Personas.
*/
public class PeopleList {
    Vector listaPersonas; // Atributo que identifica un vector de personas
    /**
    * Constructor de la clase ListaPersonas
    */
    public PeopleList() {
        listaPersonas = new Vector(); // Crea el vector de personas
    }
    /**
    * Método que permite agregar una persona al vector de personas
    * @param p Parámetro que define la persona a agregar al vector de
    * personas
    */
    public void anadirPersona(Person p) {
        listaPersonas.add(p);
    }
    /**
    * Método que permite eliminar una persona del vector de personas
    * @param i Parámetro que define la posición a eliminar en el vector
    * de personas
    */
    public void eliminarPersona(int i) {
        listaPersonas.removeElementAt(i);
    }
    /**
    * Método que permite eliminar todos los elementos del vector de
    * personas
    */
    public void borrarLista() {
        listaPersonas.removeAllElements();
    }
}
