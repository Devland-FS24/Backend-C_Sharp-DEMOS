using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_Ref
{
    // Page 63
    class Program
    {
        //Para usar un parametro ref, tanto la definicion del metodo
        //como la invocacion al mismo deben usar explicitamente la 
        //palabra clave 'ref', tal como se ve en el siguiente ejemplo:

        //Definicion del metodo.
        static void Method(ref int i)
        {
            //Deja el puntero del mouse sobre la variable i, para verificar
            //que es un tipo 'int'.
            //La siguiente declaracion podria causar un error de compilacion
            //si la variable i se 'empaquetara'(boxing) como si fuera un
            //objeto
            i = i + 44;
        }


        static void Main()
        {

            //Comentar este bloque para probar RefExample2:
            //int val = 1;
           
            //Invocacion al metodo
            //Method(ref val);
            //Console.WriteLine(val);
            //Comentar el bloque de arriba para probar RefExample2
            // Resultado: 45

            //NOTESE: QUE AL PONER EL PUNTERO DEL MOUSE SOBRE LA 
            //VARIABLE VAL, TANTO EN LA DEFINICION DEL METODO, COMO EN 
            //LA INVOCACION, EL VALOR SE MODIFICA AUTOMATICAMENTE, 
            //CADA VEZ QUE SE MODIFICA EL VALOR DE LA VARIABLE.


            //RefExample2

            //1)Declare una instancia de la clase Product y muestre sus 
            //valores iniciales:

            //Descomente este bloque de codigo para compilar y
            //debugear y probar:

            Product item = new Product("Fasteners", 54321);
            Console.WriteLine("Valores originales en Main. Name: {0}, ID: {1}\n", item.ItemName, item.ItemID);

            //2)Envie el item al metodo ChangeByReference como un argumento
            // ref

            ChangeByReference(ref item);
            Console.WriteLine("Valores de regreso en Main.  Name: {0}, ID: {1}\n", item.ItemName, item.ItemID);
            //Descomente el bloque de codigo de arriba para compilar y
            //debugear y probar.

            // Resultado:  
            //Valores originales en Main.  Name: Fasteners, ID: 54321 
            //Valores de regreso en Main.  Name: Stapler, ID: 12345


        }

        //RefExample2
       
        //Los ejemplos anteriores demuestran que pasa cuando pasas
        //tipo valor por referencia. Tambien podes usar la palabra clave ref
        //para pasar tipos referencia. Pasar un tipo-referencia por 
        //referencia, te permite que los metodos invocados modifiquen el 
        //objeto al cual se refiere el parametro de referencia. La 
        //ubicacion de almacenamiento del objeto es pasada al metodo
        //como el valor del parametro de referencia.
        //Si cambia la ubicacion de almacenamiento del parametro, tambien
        //cambia en consecuencia, la ubicacion de almacenamiento del 
        //correspondiente argumento. El siguiente ejemplo pasa una instancia
        //de un tipo-referencia como un parametro 'ref'.

        static void ChangeByReference(ref Product itemRef)
        {
            //La siguiente linea cambia la direccion que esta almacenada
            //en el parametro itemRef. Debido a que itemRef es un parametro
            //ref, la direccion que esta almacenada en la variable item en
            //el bloque de codigo static void Main(), tambien resulta
            //modificada:

            itemRef = new Product("Stapler", 99999);

            // Podes cambiar el valor de una de las propiedades de itemRef.
            // El cambio ocurre tambien, para la variable item en el 
            // bloque Main.
            itemRef.ItemID = 12345;

            //NOTESE: DADO QUE EL METODO ChangeByReference 
            //SOLAMENTE MODIFICA EL PARAMETRO
            //QUE SE LE ESTA PASANDO, AL COLOCAR EL PUNTERO DEL MOUSE
            //SOBRE EL OBJETO item EN MAIN, NO ES POSIBLE VER SU CONTENIDO
            //HASTA QUE EL METODO HAYA FINALIZADO SU EJECUCION.
            
            //NOTESE 2: ADEMAS, QUE EN LA DEFINICION DE LA CLASE Product,
            //NINGUNA DE SUS PROPIEDADES ES DECLARADA 'REF'.
            //SIN EMBARGO, ESTAS SON POR DEFECTO TIPOS REFERENCIA.
            //PARA ESTE EJEMPLO SE USAN DATOS TIPO STRING, PARA LOS
            //PARAMETROS DE LA CLASE Prouct, LOS CUALES SON TIPOS REFERENCIA.

            //NOTESE 3: EL METODO ChangeByReference ES DE TIPO VOID, 
            //LO CUAL SIGNIFICA QUE NO DEVUELVE INFORMACION AL PROGRAMA
            //MAIN O PRINCIPAL. ESTE ES EL OBJETIVO DEL MODIFICADOR 'REF':
            //PODER MODIFICAR DATOS 'INTERNAMENTE' Y QUE PUEDAN SER 
            //APROVECHADOS POR EL PROGRAMA PRINCIPAL, AUN CUANDO LA
            //NATURALEZA DE LA DEFINICION DEL METODO NO LO PERMITA.


            //NOTESE 4: EN LA LINEA 31, REEMPLACE EL CODIGO
            //int val = 1; POR ESTA OTRA LINEA:
            //int val; 
            //AL INTENTAR PROBAR EL METODO 'Method(ref val);'
            //PODRA OBSERVAR EL ERROR DEL COMPILADOR 
            //'VARIABLE NO ASIGNADA'

            //CONSULTE LA DOCUMENTACION EN LINEA DE C#, QUE TIPOS DE DATOS
            //NATIVOS DE C# SON TIPO REFERENCIA Y CUALES SON TIPO VALOR.
        }

    }
}
