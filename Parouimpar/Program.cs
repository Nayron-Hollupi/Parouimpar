using System;

namespace Parouimpar
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Declarar
			int numero1 , numero2 , soma;


			//Escrever
			Console.WriteLine("Informe um numero inteiro : ");

			//Ler
			numero1 = Convert.ToInt32(Console.ReadLine());

			//Escrever
			Console.WriteLine("Informe um numero inteiro : ");

			//Ler
			numero2 = Convert.ToInt32(Console.ReadLine());

			//Calculo
			soma = numero1 + numero2;

			//Condição Se
			if (soma == 0)
			{
				//Escreva
				Console.WriteLine("O numero {0} eh neutro!  ", soma);
			}
			//Senao
			else
			{
				//Se
				if (soma % 2 == 0)
				{
					//Escreva
					Console.WriteLine("O numero {0} eh par!  ", soma);
				}
				//Senao
				else
				{
					//Escreva
					Console.WriteLine("O numero {0} eh impar!  ", soma);


				}
			}
		
			
			Console.ReadLine();




		}

	
	}
}
