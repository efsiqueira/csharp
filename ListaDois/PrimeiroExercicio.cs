using System;

public class PrimeiroExercicio
{
    public static void Main()
    {
        // Crie um programa que imprima a tabuada de 0 a 10
        Console.WriteLine("Insira o número a ser calculado a tabuada: ");
        int numeroTabuada = Convert.ToInt32(Console.ReadLine());

        for(int contador = 0; contador <= 10; contador++)
        {
            Console.WriteLine(numeroTabuada + " x " + contador + " = " + (numeroTabuada * contador));
        }

    }
}