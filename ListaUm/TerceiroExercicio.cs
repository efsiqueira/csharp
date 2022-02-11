using System;
					
public class TerceiroExercicio
{
	public static void Main()
	{
		
        // Crie um programa que teste se um número é primo
        int numeroVerificado = 858, contaPrimo = 0;

        for(int contador = 2; contador < numeroVerificado; contador++)
        {
            if (numeroVerificado % contador == 0)
            {
                contaPrimo++;
            }
        }

        if(contaPrimo > 0)
        {
            Console.WriteLine("Não é primo");
        }
        else
        {
            Console.WriteLine("É primo");
        }

	}
}