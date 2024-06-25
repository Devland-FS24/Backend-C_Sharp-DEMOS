using System;
using System.Collections;


namespace MyCollections2
{
    // A class that works just like ArrayList, but sends event
    // notifications whenever the list changes:
    public class ListWithChangedEvent : ArrayList
    {
        // An event that clients can use to be notified whenever the
        // elements of the list change:

        //So to speak, Changed es un "evento" y "delegado", al mismo tiempo.
        //Dado que es anonimo, sera invocado tantas veces, como 
        //elementos se agreguen a la lista. En cada "agregacion",
        //se asignara una implementacion al "evento delegado"
        //y sera invocado muchas veces. Por tal razon, se lo considera
        //MultiCast delegate en tiempo de ejecucion.
        public event EventHandler Changed;

        // Invoke the Changed event; called whenever list changes:
        protected virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
                Changed(this, e);
        }

        // Override some of the methods that can change the list;
        // invoke event after each:
        public override int Add(object value)
        {
            int i = base.Add(value);
            OnChanged(EventArgs.Empty);
            return i;
        }

        public override void Clear()
        {
            base.Clear();
            OnChanged(EventArgs.Empty);
        }

        public override object this[int index]
        {
            set
            {
                base[index] = value;
                OnChanged(EventArgs.Empty);
            }
        }
    }
}

namespace TestEvents2
{
    using MyCollections2;

    class EventListener
    {
        private ListWithChangedEvent List;

        public EventListener(ListWithChangedEvent list)
        {
            List = list;
            // Add "ListChanged" to the Changed event on "List":
            // Multicast Delegates, meaning it can store more than one 
            // reference to the methods in a single delegate. 
            // To accomplish that, we have used the += operator. 

            List.Changed += new EventHandler(ListChanged);
        }

        // This will be called whenever the list changes:
        // This is an implementation of Named Method.
        // ListChanged will be invoked, regarding the signature
        // matching with the event "Changed"
        private void ListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("This is called when the event fires.");
        }

        public void Detach()
        {
            // Detach the event and delete the list:
            List.Changed -= new EventHandler(ListChanged);
            List = null;
        }
    }


}


