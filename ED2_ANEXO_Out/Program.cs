using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_Out
{
    // Page 62
    class Program
    {
        //Comentar este metodo para probar OutReturnExample
        //Descomentar la otra version de este metodo para probar
        // OutReturnExample
        //static void Method(out int i)
        //{
        //    i = 44;
        //}

        static void Main(string[] args)
        {
            //Para usar un parametro 'out', tanto la definicion del metodo
            //, como la invocacion al mismo, deben utilizar explicitamente
            //la palabra clave 'out'.
            //Por ejemplo:

            //int value;
            //value is now 0 (default assigned value)

            //Method(out value);
            // value is now 44


            //OutReturnExample
            // Descomentar este bloque para probar  y debugear este ejemplo:
            int value;
            string str1, str2;
            //Los siguientes son valores por defecto 
            //value is now 0
            //str1 is now 'null'
            //str2 is now 'null'
            

            Method(out value, out str1, out str2);
            // value is now 44 
            // str1 is now "Me retornaron" 
            // str2 is (todavia) null;
        }


        //OutReturnExample
        
        //Declarar un metodo con todos los parametros con 'out' es util
        //cuando queres un metodo que retorne multiples valores. El siguiente
        //ejemplo utiliza 'out' para retornar tres variables con un simple
        //llamado al metodo. Notese que al tercer argumento se le asigna 
        //'null'. Esto permite a los metodos retornar valores opcionalmente.

        //Descomentar este bloque para probar  y debugear este ejemplo:
        static void Method(out int i, out string s1, out string s2)
        {
            i = 44;
            s1 = "Me retornaron";
            s2 = null;

        //Aunque las variables pasadas como argumentos 'out' no tienen
        //que ser inicializadas antes de ser pasadas, se requiere que el 
        //metodo invocado asigne un valor antes de que el metodo retorne 
        //al programa principal.

         //NOTESE: SI SE BORRAN LAS TRES LINEAS DE CODIGO DE ESTE METODO,
         //Y SE VUELVE A COMPILAR, PODRAS OBSERVAR UN ERROR DE COMPILACION:
         //LA VARIABLE 'i' DEBE ASIGNARSE ANTES DE ABANDONAR LA EJECUCION
         //DEL ACTUAL METODO.
         
         //NOTESE 2: AL COMPARAR ESTE COMPORTAMIENTO CON EL SUGERIDO
         //EN EL COMENTARIO 'NOTESE 4', DEL PROYECTO ED2_ANEXO_Ref, 
         //PODRA INTUIR LA DIFERENCIA QUE SUBYACE ENTRE 'REF' Y 'OUT'
        }

    }
}
