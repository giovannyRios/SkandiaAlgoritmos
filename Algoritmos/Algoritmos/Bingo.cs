using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{

	public static class Bingo
	{
		/// <summary>
		/// Algoritmo que valida en una lista de 1 a 100 que numeros son divisibles entre 3 y 5 o ambos e imprime palabra Bingo
		/// de acuerdo a las validaciones
		/// </summary>
		public static string DivisiblesBingo()
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 1; i <= 100; i++)
			{
				if (i % 3 == 0 && i % 5 == 0)
				{
					sb.Append(i + " -> Bingo!" + Environment.NewLine);
				}
				else if (i % 3 == 0)
				{
					sb.Append(i + " -> Bin" + Environment.NewLine);
				}
				else if (i % 5 == 0)
				{
					sb.Append(i + " -> Go" + Environment.NewLine);
				}
			}
			return sb.ToString();
		}
	}
}
