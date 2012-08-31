using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace numeroFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULO DEL FACTORIAL DE UN NUMERO");
            
            string Continuar = "S";
            int numFactorial;
            int numero;

            while (Continuar.ToUpperInvariant() == "S")
            {
                numFactorial = 1;
                Console.WriteLine("Introduzca el numero del que desea el factorial");
                numero = int.Parse(Console.ReadLine());
                
                for (int a = 1; a <= numero; a++)
                {
                    numFactorial = numFactorial * a;
                }

                Console.WriteLine("El factorial del numero ingresado es : "+numFactorial);
                Console.WriteLine("Si desea buscar otro factorial ingresar S de lo contrario ingrese N");
                Continuar = Console.ReadLine();
            }
        }
    }
}
