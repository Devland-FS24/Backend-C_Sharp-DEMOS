using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEFY_IDisposableDoneRight
{

    public interface IDisposable
    {
        void Dispose();
    }

    public class MyClass : IDisposable
    {
        private static Object Lock = new Object();
        private static Dictionary<UInt64, MyClass> LiveInstances = new Dictionary<UInt64, MyClass>();

        public UInt64 Id { get; private set; }

        public MyClass()
        {
            lock (Lock)
            {
                var newId = IncrementalId();
                if (newId == 0)
                {
                    throw new ArgumentException("Reached MAX VAL");
                }
                Id = newId;
                LiveInstances.Add(Id, this);
            }
        }

        ~MyClass()
        {
            CleanUpNativeResources();
        }

        public void Dispose()
        {
            lock (Lock)
            {
                CleanUpManagedResources();
                CleanUpNativeResources();
                GC.SuppressFinalize(this);
            }
        }

        protected virtual void CleanUpManagedResources()
        {
            LiveInstances.Remove(Id);
            // free other managed objects that implement
            // IDisposable only
        }
        protected virtual void CleanUpNativeResources()
        {
            // release any unmanaged objects
            // set the object references to null
        }

        private static UInt64 IncrementalId()
        {
            for (ulong i = 0; i <= Convert.ToUInt64(LiveInstances.Count); i++)
            {
                if (i != UInt64.MaxValue && !LiveInstances.ContainsKey(i + 1))
                {
                    return i + 1;
                }
            }
            return 0;
        }
    }

    class IDisposeTest
    {
    }

}
