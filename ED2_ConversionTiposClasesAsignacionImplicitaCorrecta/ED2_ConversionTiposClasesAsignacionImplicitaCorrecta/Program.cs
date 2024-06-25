using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ConversionTiposClasesAsignacionImplicitaCorrecta
{
    class Program
    {
          // Page 28
        static void Main(string[] args)
        {
            //Lo siguiente es correcto porque el 
            // "tipo dinámico" del objeto es de clase B.

            //Notese que la creacion del objeto "a", implica una relacion
            //de herencia "implicita", con la clase derivada B
            A a = new B();

            //Esta instruccion es correcta, pues el objeto "b" ha sido creado
            //dinamicamente al instanciar el objeto "a" dinamicamente, invocando
            //al constructor de la clase B.
            //Aqui no es necesario B b = new B(); para proporcionar memoria dinamica
            //al objeto b.
            B b;

            
            b = (B)a;

            //Esta asignacion es valida:
            b.b = 3;

            //Moraleja: Se invita al lector a imaginar para que puede servir
            //un escenario como el presentado por el ejemplo 28

            // Page 29
            //Conversión de tipos entre clases
            // Para los métodos se siguen las mismas reglas:
            //• Si el método está sobreescrito, siempre se ejecuta el
            //método del tipo dinámico, independientemente de que
            //exista conversión de tipo o no.

            //Por ejemplo, si existiera el metodo 
            //override void Sumar(){}, en la clase B,
            //al realizar la operacion 
             b.Sumar();               //, se ejecutaria
            //el metodo Sumar(), de la clase B (el tipo dinamico)

            // El "tipo dinamico" es aquel que resulta invocado luego
            //de la sentencia "new", a la hora de crear un objeto.
            //En este ejemplo, cuando se crea el objeto "a", se invoca al
            //tipo dinamico de la clase B
        }
    }
}
