using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
	public static class NumerosPrimos
	{

		public static List<int> NumerosPrimosCribaDeEratostenes(int n)
		{
			/* 
			 * Heuristica para encontrar el limite  superior de 
			 * los numeros primos, dada la cantidad de primos solicitados en n
			 */
			int limite = (int)(n * (Math.Log(n) + Math.Log(Math.Log(n)))) + 3;


			bool[] esPrimo = new bool[limite + 1];
			List<int> primos = new List<int>();

			/* 
			 * Se parte de la presunción de que todos los números hasta el limite 
			 * Heuristico hallado son primos y se van marcando los que no lo son
			 * Aqui se aplica un refinamiento a la criba de Eratostenes
			 * ya que se sabe que los numeros pares > 2 no son primos 
			 */
			for (int i = 2; i <= limite; i++)
				esPrimo[i] = i % 2 == 0 && i > 2 ? false : true;



			for (int p = 2; p <= limite; p++)
			{
				if (esPrimo[p])
				{
					primos.Add(p);

					/* 
					 * Detenerse después de encontrar los n primos
					 * solicitados en el parametro del metodo 
					 */
					if (primos.Count == n)
						break;

					/*
					 * Se comienzan a marcar los multiplos superiores a p como no primos
					 * empezando por 2, aqui se debe tener en cuenta que todos los numeros
					 * pares > 2 ya fueron descartados
					 */
					for (int multiplo = p * p; multiplo <= limite; multiplo += p)
					{
						esPrimo[multiplo] = false;
					}
				}
			}

			return primos;
		}


	}
}
