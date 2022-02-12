using System;

public class PrimeiroExercicio
{
    public static void Main()
    {
        // Crie um programa que questione a quantidade de notas a ser informada, receba as notas e calcule a média

        int quantidadeNotas;
        double valor, soma;

        Console.WriteLine("Quantas notas deseja informar?");
        quantidadeNotas = Convert.ToInt32(Console.ReadLine());

        for(int contador = 1; contador <= quantidadeNotas; contador++)
        {
            Console.WriteLine("Digite a " + contador + " ª nota: ");
            valor = Convert.ToDouble(Console.ReadLine());

            soma += valor;
        }
        Console.WriteLine("A média das notas é: " + (soma/quantidadeNotas));

    }
}