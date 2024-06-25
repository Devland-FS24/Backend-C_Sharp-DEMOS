using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DEFY_DivisibleByNoModulus
{
    public static class DivisibleNoModulus
    {
        public static string Divide(decimal numerator, decimal denominator)
        {


            //check the param
            if (numerator == 0) { return "0"; }
            if (denominator == 0) { throw new DivideByZeroException(); }


            //format the param 
            string output = "";

            if ((numerator < 0 && denominator > 0) || (numerator > 0 && denominator < 0))
            {
                output += "-";
            }

            numerator = Math.Abs(numerator);
            denominator = Math.Abs(denominator);

            //start dividing 
            int decimalPlaceCounter = 0;
            int subtractCounter = 0;
            bool containsDecimalPlace = false;

            while (numerator > 0 && decimalPlaceCounter < 10)
            {

                if (numerator < denominator)
                {
                    //append the number of times the denominator goes into the numerator 
                    output += subtractCounter.ToString();

                    //add a decimal places
                    if (!containsDecimalPlace)
                    {
                        containsDecimalPlace = true;
                        output += ".";
                    }

                    //handle the remainer by multiplying it by 10.
                    numerator = numerator * 10;

                    //reset counters 
                    subtractCounter = 0;

                    //increment decimal counter, since we dont want an infinite loop
                    decimalPlaceCounter++;

                }
                else
                {

                    //denominator goes into the numerator at least once. increment the counter
                    numerator = numerator - denominator;
                    subtractCounter++;
                }
            }

            output += subtractCounter.ToString();
            return output;

        }

        public static string Divisible(decimal numerator, decimal denominator)
        {


            //check the param
            if (numerator == 0) { return "0"; }
            if (denominator == 0) { throw new DivideByZeroException(); }


            //format the param 
            string output = "";

            if ((numerator < 0 && denominator > 0) || (numerator > 0 && denominator < 0))
            {
                output += "-";
            }

            numerator = Math.Abs(numerator);
            denominator = Math.Abs(denominator);

            //start dividing 
           
            int subtractCounter = 0;
            bool containsDecimalPlace = false;

            while (numerator > 0 && !containsDecimalPlace)
            {

                if (numerator < denominator)
                {                  
                    if (!containsDecimalPlace)
                    {
                        containsDecimalPlace = true;                     
                    }
                }
                else
                {

                    //denominator goes into the numerator at least once. increment the counter
                    numerator = numerator - denominator;
                    subtractCounter++;
                }
            }

            if(containsDecimalPlace)
            {
                output = "El numerador NO ES divisible por el denominador.";
            }
            else
            {
                output = "El numerador divisible por el denominador.";
            }

            return output;
        }

        public static bool DivisibleLineByLine(string entrada)
        {

            BigInteger stringtest = SecureConvertToNumber(entrada);


            //check the param
            if (stringtest == 0) { return false; }
           
            //stringtest = Math.Abs(stringtest);

            int subtractCounter = 0;
            bool containsDecimalPlace = false;

            while (stringtest > 0 && !containsDecimalPlace)
            {
                Console.WriteLine(stringtest);

                if (stringtest < 11)
                {
                    if (!containsDecimalPlace)
                    {
                        containsDecimalPlace = true;
                    }
                }
                else
                {
                    stringtest = stringtest - 11;
                    subtractCounter++;
                }
            }

            if (containsDecimalPlace)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool EsDivisiblePor11(string entrada)
        {
            //Convierte a numero, si puede
            BigInteger stringtest = SecureConvertToNumber(entrada);

            //check the param
            if (stringtest == 0) { return false; }

            //Por el caso que el numero sea negativo
            //stringtest = Math.Abs(stringtest);

            bool EsDivisibleX11 = false;
            bool tieneMasDeDosDigitos = false;
            BigInteger nuevoNumero = 0;

            //Verificar si tiene mas de 2 digitos
            tieneMasDeDosDigitos = VerifyNumberOfDigits(stringtest);

            //Entro al ciclo while
            while (stringtest > 0 && tieneMasDeDosDigitos)
            {
                nuevoNumero = ObtenerNuevoNumero(stringtest);                
                Console.WriteLine(nuevoNumero.ToString());
                tieneMasDeDosDigitos = VerifyNumberOfDigits(nuevoNumero);
                stringtest = nuevoNumero;
            }

            if (!tieneMasDeDosDigitos)
            {
                if (DivisibleLineByLine(nuevoNumero.ToString()))
                {
                    EsDivisibleX11 = true;
               
                }
                else
                {
                    EsDivisibleX11 = false;
                  
                }
            }
            return EsDivisibleX11;
        }

        private static BigInteger ObtenerNuevoNumero(BigInteger stringtest)
        {
            BigInteger dblNuevoNumero = 0;
            BigInteger dblUltimoDigito = 0;
            BigInteger dblNumeroTruncado = 0;

            string numeroTruncado = "";

            //Obtengo el ultimo digito
            string ultimoDigito = "";
            string mystring = stringtest.ToString();
            int fromrange = mystring.Length - 1;
            int torange = mystring.Length;
            ultimoDigito = mystring.Substring(fromrange, torange-fromrange);

            //Obtengo el numero que resulta de borrarle el ultimo digito
            numeroTruncado = mystring.Remove(mystring.Length - 1);

            //Al numero truncado le resto el digito borrado
            BigInteger.TryParse(numeroTruncado, out dblNumeroTruncado);
            BigInteger.TryParse(ultimoDigito, out dblUltimoDigito);
            dblNuevoNumero = dblNumeroTruncado- dblUltimoDigito;

            //Retorno el nuevo numero
            return dblNuevoNumero;

        }

        private static bool VerifyNumberOfDigits(BigInteger stringtest)
        {
            int test = 0;
            test = stringtest.ToString().Length;

            return test > 2 ? true : false;
        }

        public static BigInteger SecureConvertToNumber(string myentrada)
        {
            BigInteger x = 0;
            BigInteger.TryParse(myentrada, out x);

            return x;
        }
    }

    //NS
}
