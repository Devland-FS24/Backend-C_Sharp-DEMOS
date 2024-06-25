using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerLib
{
    public class Button
    {

       private bool mfState;

       public bool State
       {
           get
           {
               State = mfState;
               return State;
           }
           set
           {
               mfState = value;
           }
       }

       public void Toggle()
       {
         mfState = false;
       }
        
    }
}
