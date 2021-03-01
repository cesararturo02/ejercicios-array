using System;

namespace _10_numeros_y_luego_calcule_y_muestre_cual_es_el_mayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int num, NumMayor = 0, x = 0;
            for (num = 0; num < 10; num++)
            {
                Console.WriteLine("escriba el {0}° numero: ", (num + 1));
                numeros[num] = Convert.ToInt32(Console.ReadLine());
            }
            while (x < 10)
            {
                if (numeros[x] > NumMayor)
                    NumMayor = numeros[x];
                x++;
            }
            Console.WriteLine("de los numeros introducidos el mayor es: "+NumMayor);
            Console.ReadKey();
        }
    }
}
