using Algoritmos;
using System;

Console.WriteLine("**************** Algoritmo A ****************");
#region Bingo
Console.WriteLine(Bingo.DivisiblesBingo());
#endregion

Console.WriteLine("**************** Algoritmo B ****************");

#region primeros50Primos

bool salir = false;

do
{

	Console.WriteLine("Ingrese la cantidad de primos que desea ver: ");
	int cantidadPrimos = 0;

	try
	{
		cantidadPrimos = int.Parse(Console.ReadLine());

		if (cantidadPrimos < 2)
		{
			Console.WriteLine("Ingrese un número mayor a 2");

		}
		else
		{
			var listaPrimos = NumerosPrimos.NumerosPrimosCribaDeEratostenes(cantidadPrimos);
			Console.WriteLine("Los primeros " + cantidadPrimos + " números primos son: ");
			foreach (var primo in listaPrimos)
			{
				Console.Write(primo + " ");
			}
		}

	}
	catch (Exception)
	{
		Console.WriteLine("Ingrese un número válido");

	}




	Console.WriteLine("¿Desea salir? (s/n)");
	string respuesta = Console.ReadLine();
	salir = respuesta.Equals("s") ? true : false;

} while (!salir);

#endregion

Console.WriteLine("**************** Algoritmo C ****************");

#region cadenaTextoAlReves
try
{
	Console.WriteLine("Ingrese una cadena de texto: ");
	string cadena = Console.ReadLine();
	var arrayDePalabras = cadena.Split(" ");
	Array.Reverse(arrayDePalabras);
	Console.WriteLine($"La cadena de texto al revés es: {string.Join(" ", arrayDePalabras)}");
}
catch (Exception ex) 
{ 
	Console.WriteLine($"Ocurrio un error, detalle: {ex.Message} ");
}
#endregion
