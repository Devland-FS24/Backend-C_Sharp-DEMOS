using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED2_ClaseAbstracta
{
    class Program
    {
        // Page 30
        static void Main(string[] args)
        {

            B b = new B();

            b.llamame();
            b.llamametambien();
            b.gritame();


            //Se invita al lector a crear un ejemplo que implemente la
            //clase C y que saque sus propias conclusiones, acerca de la
            //eficiencia que provee la "abstraccion", provista por el concepto
            //de clase abstracta.

            //            Clases abstractas (abstract)
            //• Objetivo: Declarar la estructura de una abstracción sin 
            //   proporcionar una implementación para cada método.

            //• La superclase abstracta determina la naturaleza de 
            //  los métodos que las subclases deben implementar.

            //EJEMPLO:

            // public abstract class <nombre>(lista_de_parametros);

            //• Características:
            //ü Cualquier clase que contenga uno o varios métodos 
            //  abstractos también se tiene que declarar como abstract.

            //ü No pueden haber objetos (instancias) de una 
            //  clase abstracta.

            //ü No se pueden declarar constructores abstractos o 
            //  métodos abstractos estáticos.

            //• Cualquier subclase de una clase abstracta ha de 
            //  implementar todos los métodos astractos de la 
            //  superclase o ser declarada también como abstracta.

            //* Una clase abstracta puede tener metodos concretos o 
            // "no abstractos".

            //Una clase abstracta puede tener metodos concretos virtuales.

            //C# no soporta herencia multiple:
            //El siguiente ejemplo, no compila:
            //public class B : A,C

            //SE SUGIERE RECORDAR O RELEER EL DOCUMENTO
            //ANALISIS PRINCIPIO SOLID, PARA PODER ENGANCHAR
            //EL CONCEPTO DE CLASE ABSTRACTA, CON TAL PRINCIPIO:
            // ASI ES. SE RELACIONA CON EL PRINCIPIO "S":
            //SINGLE RESPONSIBILITY: PROVEER UNA FUNCIONALIDAD DEFINIDA
            // A CADA CLASE, LO CUAL TAMBIEN SE DEFINE COMO ALTA COHESION.
            //TAMBIEN SE RELACIONA CON EL PRINCIPIO "O":
            //OPEN/CLOSED: CERRADO PARA MODIFICAR, ABIERTO PARA EXTENDER.



            //LAS CLASES ABSTRACTAS, AL IGUAL QUE LAS CLASES BASE CONCRETAS, 
            //HACEN QUE SUS CLASES DERIVADAS, DEPENDAN DE ELLAS.
            //EXISTE UN ALTO ACOPLAMIENTO.
            //POR LO QUE NO SON BUENAS CANDIDATAS A LA HORA DE PENSAR
            //EN ARQUITECTURAS DE CLASES DESACOPLADAS O DE BAJO ACOPLAMIENTO.

            //LAS CLASES ABSTRACTAS SE RECOMIENDAN PARA
            //ARQUITECTURAS DE CLASES DEPENDIENTES, CUYO
            //DESARROLLO O CRECIMIENTO O EXPANSION, SE CALCULA DESDE
            //SU CREACION QUE NO SUFRIRA CAMBIOS

            //SE PUEDE CITAR COMO EJEMPLO, UN CONJUNTO DE REGLAS
            //DE NEGOCIO BASICAS O NUCLEO CENTRAL O MOTOR, DE UNA SOLUCION
            //DE SOFTWARE, QUE SIEMPRE REQUERIRA DE CIERTAS CLASES BASE ABSTRACTAS
            //, BASE CONCRETAS O UNA COMBINACION DE AMBAS, PARA PODER FUNCIONAR.

        }
    }
}
