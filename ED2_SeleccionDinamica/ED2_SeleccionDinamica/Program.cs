using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_SeleccionDinamica
{
    class Program
    {
           // Page 20
        static void Main(string[] args)
        {
            A a = new A();
           

            B b = new B();
           

            C c = new C();
           
            //Aqui vemos como la misma llamada al mismo metodo, del mismo
            //objeto, funciona para este ejemplo tanto para c# como para
            //JAVA.
            //Imaginar que pasa si, se pudiera pasar como parametro el objeto b
            //y / o el objeto c y se pudiera pensar en algun metodo de negocios
            //que lograra asignar el objeto b o el c al objeto r, a traves
            //de alguna logica de negocios.
            //Alli se veria un ejemplo perfecto del poder que tiene el enlace dinamico, 
            //solo para este ejemplo. Aunque se podria pensar en otra forma, menos
            //dependiente del objeto "b" o "c", para que el metodo pudiera delegar
            //el objeto que se asignara al objeto "r", siempre y cuando cumpla
            //con las reglas jerarquia de clases, para este ejemplo.
            //Eso se deja como tarea al lector...
            //VER NOTAS EN DETALLE DE LAS CLASES...
            A r = new A();
            r.llamame();

            r = b;
            r.llamame();

            r = c;
            r.llamame();

            //Page 22

            //Ventajas del Enlace Dinámico:
            //* La sobreescritura de métodos permite a Java y C# admitir el polimorfismo
            //  en tiempo de ejecución.
            //* El polimorfismo es esencial en la programación OO por una sencilla
            //  razón:
            //  Permite que una clase general especifique métodos que serán
            //  comunes a todas sus clases derivadas, permitiendo a éstas definir la
            //  implementación específica de alguno de estos métodos.
            //* Esta forma de polimorfismo dinámico durante la ejecución es uno de
            //  los mecanismos más poderosos que ofrece el diseño OO para soportar:
            //          1)La reutilización de código 
            //          2)Brindar robustez a la arquitectura.
            //* La capacidad que tienen las bibliotecas de código existentes, de llamar
            //  a métodos de instancias nuevas de clases sin volver a compilarlos, pero
            //  manteniendo a la vez la interfaz abstracta y limpia, es una herramienta
            //  profundamente poderosa.
        }
    }
}
