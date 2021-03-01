using System;

namespace los_dias_que_tienen_los_meses
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] dias = new int[4];
			dias[1] = 31;
			dias[2] = 30;
			dias[3] = 28;

			int[] meses = new int[13];
			meses[1] = dias[1];
			meses[2] = dias[3];
			meses[3] = dias[1];
			meses[4] = dias[2];
			meses[5] = dias[1];
			meses[6] = dias[2];
			meses[7] = dias[1];
			meses[8] = dias[1];
			meses[9] = dias[2];
			meses[10] = dias[1];
			meses[11] = dias[2];
			meses[12] = dias[1];

			int mes = 0;
			Console.WriteLine("seleccione un mes ");
			
			mes = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("El mes número {0} tiene {1} dias", mes, meses[mes]);
		}
    }
}
