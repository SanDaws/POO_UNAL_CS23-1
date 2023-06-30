using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;//clasepara leer archivos
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.IO.Pipes;
using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;
/*
* En C#, se usa el "fileStream", una subclase de System.IO para la lectura
* y escritura de archivos
* en ves de utilizar palabras claves dentro de su uso, se usan metodos de la clase.
*/
namespace CRUD
{
    public class CRUD
    {
        public CRUD() { }
        public String _path = @"C:\Windows\Temp\~Trabajo6.txt";


        public void Create(datos _datos)
        {
            try
            {
                if (!File.Exists(_path))//si no existe un archivo
                {
                    using (StreamWriter _escritor = new StreamWriter(_path))//creamos un archivo
                    {
                        _escritor.WriteLine($"{_datos._nombre}~{_datos._numero}");
                    }


                }
                else
                {
                    using (StreamWriter _escritor = File.AppendText(_path))
                    { // lo abrimos

                        _escritor.WriteLine($"{_datos._nombre}~{_datos._numero}", 0);


                    }
                }
            }
            catch (Exception)
            {
                if (_datos._nombre == "" || _datos._numero == null)
                {
                    MessageBox.Show("falta informacion");
                }
            }



        }
        public List<String> Read()
        {
            String _linea = "";
            List<String> __palabras = new List<string>();
            
            try
            {
                using (StreamReader _lector = new StreamReader(_path))
                {

                    while ((_linea = _lector.ReadLine()) != null)
                    {
                        
                        _linea = _lector.ReadLine();

                        String[] palabras = _linea.Split('~');
                        __palabras.Add(palabras[0]);
                        __palabras.Add(palabras[1]);
                        
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ruta no encontrada");
            }
            return __palabras;
        }
        public void update(datos _datos)
        {

        }
        public void delete(datos _datos)
        {

        }


    }
    public class datos
    {
        //datos que almacenaremos
        public string _nombre;
        public Double _numero;

        public datos() { }


    }
}
