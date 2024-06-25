//El siguiente ejemplo muestra como definir una directiva using y
//un alias using para una clase:

using System;



namespace NameSpace1
{
    

    public class MyClass
    {
        public override string ToString()
        {
            return "You are in NameSpace1.MyClass.";
        }
    }

}

namespace NameSpace2
{
   

    class MyClass<T>
    {
        public override string ToString()
        {
            return "You are in NameSpace2.MyClass.";
        }
    }
}
