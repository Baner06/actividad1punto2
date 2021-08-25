using System;

namespace actividad1punto2
{
	public class Program
	{
		public static void Main()
		{
			double pulsacionesPorSegundo;
			int genero, edad;
			Console.WriteLine("POR FAVOR INGRESE LOS DATOS SOLICITADOS:\n");
			Console.WriteLine("Digite Su Edad:");
			edad = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Seleccione el Genero\n1 Femenino\n2 Masculino");
			genero = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nRESULTADOS:\n");
			if (genero == 1)
			{
				pulsacionesPorSegundo = (Double)(220 - edad) / 10;
				Console.WriteLine("El número de pulsaciones que usted debe tener es: " + pulsacionesPorSegundo + " Por cada 10 Segundos.");
			}
			else if (genero == 2)
			{
				pulsacionesPorSegundo = (Double)(210 - edad) / 10;
				Console.WriteLine("El número de pulsaciones que usted debe tener es: " + pulsacionesPorSegundo + " Por cada 10 Segundos.");
			}
			else
			{
				Console.WriteLine("Error en los datos ingresados.");
			}

		}
	}
}
