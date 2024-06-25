using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ANEXO_Static
{
    // Page 61
  	public static class Foo
	{

	    // constructor Static 
	    static Foo()
	    {
        	Bar = "fubar";
	    }


	    // propiedad Static 
	    public static string Bar 
	    { 
	      get; 
	      set; 
	    }
	}


    public class MyStaticClass
    {

        static MyStaticClass()
        { 
        
        }

        public static void SetMyData()
        { 
          //Do something with my data...
        }
    }
}
