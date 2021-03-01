using System;

namespace usuario_que_ponga_4_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[4]; 
            double suma = 0; 
            double media; 
            Console.WriteLine("Este programa captura 4 numeros por teclado proporcionados por el usuario, y despues muestra en pantalla la media y los numeros"); // Se indica al usuario que hace el programa
           
            for (int c = 0; c < 4; c++)
            {
                Console.Write("Introduzca el valor {0}: ", c + 1); 
                numeros[c] = Convert.ToDouble(Console.ReadLine()); 
                suma += numeros[c]; 
            }
            media = suma / 4;
            Console.Write("\nLos numeros introducidos fueron: "); 
            for (int c = 0; c < 4; c++)
            {
                Console.Write(" ({0}) ", numeros[c]); 
            }
            Console.Write("\nY la media aritmetica es: {0}", media);
        }
    }
}
