using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public abstract class Animal
    {
        //Atributos
        protected String _sonido, _alimento, _habitat, _nomCientifico;

        //metodos
        /*ya que es abstracto no puedo hacer nada con sus atributos por si misma
        /basicamente esta clase es demasiado amorfa  y depende de heredar estos "megaatributos"(se que esto no es un termino ortodoxo)
        pero si lo puedo usar mas abajo
        */
        public abstract String GetSonido();
        public abstract String GetAlimento();
        public abstract String GetHabitat();
        public abstract String GetNombreCientifico();

    }

    public abstract class Canidos : Animal { }
    public abstract class Felinos : Animal { }
    // tal parece que el lenguaje no me permite si no es sobreescribiendo , no entiendo muy bien el porque, buscare mas y si no, se queda asi
    // lo hago porque sino el programa me suelta un error de no impletmentar los miembros abstractos de la herencia

    public class Perro : Canidos
    {
        public override String GetSonido() { return "Ladrido"; }
        public override String GetAlimento() { return "Carnivoro"; }
        public override String GetHabitat() { return "Doméstico"; }
        public override String GetNombreCientifico() { return "Canis Lupus Familiaris"; }

    }
    public class Lobo : Canidos
    {
        public override String GetSonido() { return "Aullido"; }
        public override String GetAlimento() { return "Carnivoro"; }
        public override String GetHabitat() { return "Bosque"; }
        public override String GetNombreCientifico() { return "Canis Lupus"; }

    }
    //aun asi no estuviera e nel ejemplo, lo quice poner por ser una referencia a Fantastic Mr.fox
    public class Zorro : Canidos
    {
        public override String GetSonido() { return "Aullido"; }
        public override String GetAlimento() { return "Carnivoro"; }
        public override String GetHabitat() { return "Bosques nevados"; }
        public override String GetNombreCientifico() { return "Vulpes Vulpes"; }

    }
    public class Leon : Felinos
    {
        public override String GetSonido() { return "Rugido"; }
        public override String GetAlimento() { return "Carnivoro"; }
        public override String GetHabitat() { return "Praderas"; }
        public override String GetNombreCientifico() { return "Panthera Leo"; }
    }
    public class Gato : Felinos
    {
        public override String GetSonido() { return "Rugido"; }
        public override String GetAlimento() { return "Carnivoro"; }
        public override String GetHabitat() { return "Praderas"; }
        public override String GetNombreCientifico() { return "Panthera Leo"; }
    }
}
