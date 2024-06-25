using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//El siguiente ejemplo muestra como definir y usar un "alias" using para
//un espacio de nombres:
namespace PC
{
    // Definir un alias para el espacio de nombres anidado 
    using Project = PC.MyCompany.Project;

    class A
    {
        void M()
        {
            // Usar el alias
            Project.MyClass mc = new Project.MyClass();
        }
    }
    namespace MyCompany
    {
        namespace Project
        {
            public class MyClass { }
        }
    }

    //Comentarios
    //Un directiva "alias" para using no puede tener un tipo generico a la
    //derecha de la declaracion. Por ejemplo, no podes crear un alias using
    //para un List<T>, pero si podes crear uno para un List<int>.
}
