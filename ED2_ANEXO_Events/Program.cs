using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//SAMPLE 1
//using MyCollections;
//using TestEvents;

//SAMPLE 2
using MyCollections2;
using TestEvents2;

namespace ED2_ANEXO_Events
{
    class Program
    {
        static void Main(string[] args)
        {

            //SAMPLE 1
                 // Test the ListWithChangedEvent class.

          // Create a new list.
          //ListWithChangedEvent list = new ListWithChangedEvent();

          //// Create a class that listens to the list's change event.
          //EventListener listener = new EventListener(list);

          ////// Add and remove items from the list.
          //list.Add("item 1");
          //list.Clear();
          //listener.Detach();


            //SAMPLE 2

            // Create a new list:
            ListWithChangedEvent list = new ListWithChangedEvent();

            // Create a class that listens to the list's change event:
            // Every time an EventListener object is created, a new
            // ListChanged event will be automatically added to
            // the list
            EventListener listener = new EventListener(list);

            // Add and remove items from the list:
            // Add method implementation triggers an invocation to 
            // the event "Changed". The implementation associated for
            // this event is located within the method OnChanged
            // in the ListWithChangedEvent class.
            list.Add("item 1");
            list.Clear();
            listener.Detach();


        }
    }
}
