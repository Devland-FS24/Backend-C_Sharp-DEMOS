using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2__DependencyInversion
{
    public interface IAddress
    {
    }

    public class Address : IAddress
    {
        //Campos
        private string address = string.Empty;
        private int phone = 0;

        //Propiedades
        public string Addr
        {
            set
            {
                address = value;
            }

            get
            {
                return address;
            }
        }

        public int Pho
        {
            set
            {
                phone = value;
            }

            get
            {
                return phone;
            }
        }

        public Address()
        { 
           //Default constructor
        }

        public Address(string dire, int tel)
        {
            address = dire;
            phone = tel;
            Console.WriteLine("My address is: {0}", address);
            Console.WriteLine("My phone is: {0}", phone);
            Console.WriteLine("Ha nacido un nuevo objeto address");
        }
    }

    
}
