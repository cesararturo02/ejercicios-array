using System;

namespace Un_programa_que_pida_al_usuario_5_numeros_reales
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[5];
            Console.WriteLine("Este programa captura 5 numeros reales por teclado, y despues muestra el orden contrario al que fueron tecleados");
            for (int c = 0; c < 5; c++)
            {
                Console.Write("Introduzca el valor {0}: ", c + 1);
                numeros[c] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("\nLos numeros al contrario de como fueron introducidos son: " +numeros[4]+" ," +numeros[3]+ " ," +numeros[2]+ " ," +numeros[1]+ " y , por ultimo " +numeros[0]);
        }
    }
}
