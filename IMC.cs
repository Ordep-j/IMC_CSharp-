using System;
using static System.Console;
using static System.Convert;
public class Program
{
	public static void Main()
	{
		String nome;
		double peso;
		double altura;
		double imc;
		
		WriteLine("Insira seu nome: ");
		nome = ReadLine();
		
		WriteLine("Insira sua altura: ");
		altura = ToDouble(ReadLine());
		
		WriteLine("Insira seu peso: ");
		peso = ToDouble(ReadLine());
		
		imc = peso/(altura * altura);
		
		if (imc >= 18.5 && imc <= 24.99)
		{
			WriteLine("Olá " + nome );
			WriteLine("Seu IMC é: " + imc.ToString("F2") + " e você está com o peso Normal.");
		}
		else if (imc >= 25 && imc <= 29.99)
		{
			WriteLine("Olá " + nome );
			WriteLine("Seu IMC é: " + imc.ToString("F2") + " e você está com o Sobrepeso.");
		}
		else if (imc >= 30)
		{
			WriteLine("Olá " + nome );
			WriteLine("Seu IMC é: " + imc.ToString("F2") + " e você está com Obesidade.");
		}
		else 
		{
			WriteLine("Olá " + nome );
			WriteLine("Seu IMC é: " + imc.ToString("F2") + " e você está com o Baixo peso.");
		}
	}
}
