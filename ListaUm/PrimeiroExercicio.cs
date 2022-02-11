using System;
					
public class PrimeiroExercicio
{
	public static void Main()
	{   

        // Crie um programa que calcule a média ((nota1 + nota2 + nota3 / 3))
		double primeiraNota, segundaNota, terceiraNota, media;

        primeiraNota = 8.0;
        segundaNota = 6.5;
        terceiraNota = 7.2;

        media = (primeiraNota + segundaNota + terceiraNota) / 3;

        Console.WriteLine("A média das notas é: " + media);

	}
}