using System;

namespace Exercicio_1_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            
	        double idadeAnos;
			double idadeMeses;
			double idadeDias;
			double idadeHoras;
			double idadeMinutos;
			
	
		Console.WriteLine("Qual é a sua idade?");
		idadeAnos = double.Parse(Console.ReadLine());
		
		idadeMeses = idadeAnos * 12;
		idadeDias = idadeAnos * 365;
		idadeHoras = idadeAnos * 8760;
		idadeMinutos = idadeAnos * 525600;
		
		Console.WriteLine("Sua idade em meses é: " + idadeMeses);
		Console.WriteLine("Sua idade em dias é: " + idadeDias);
		Console.WriteLine("Sua idade em horas é: " + idadeHoras);
		Console.WriteLine("Sua idade em minutos é: " + idadeMinutos);
        }
    }
}
