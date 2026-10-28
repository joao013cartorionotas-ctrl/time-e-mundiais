using System;
					
public class Program
{
	public static void Main()
	{
		// declaraçao de variaveis 
		String time1;
		String time2;
		int mundial1;
		int mundial2;
		
		// coleta de variaveis 
		Console.WriteLine("INSIRA O PRIMEIRO TIME");
		time1 = Console.ReadLine();
		Console.WriteLine("INSIRA O SEGUNDO TIME");
		time2 = Console.ReadLine();
		Console.WriteLine("INSIRA A QUANTIDADE DE MUNDIAIS");
		mundial1 = Convert.ToInt16(Console.ReadLine());
		Console.WriteLine("INSIRA A QUANTIDADE DE MUNDIAIS");
		mundial2 = Convert.ToInt16(Console.ReadLine());
		
		// exibiçao e tratamento de dados
		Console.WriteLine("TIME COM MAIS MUNDIAIS ");
		if (mundial1 > mundial2){ 
	     Console.WriteLine("TIME " + time1 + " COM MAIS MUNDIAIS ");
		}
	    else if (mundial2 > mundial1){ 
		 Console.WriteLine("TIME " + time2 + "COM MAIS MUNDIAIS ");
		}	
		else {
		 Console.WriteLine("TIMES " + time1 + " " + time2 + " OS DOIS SAO PEQUENOS ");
		}
		
	}
}