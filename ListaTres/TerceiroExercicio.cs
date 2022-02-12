using System;

public class TerceiroExercicio
{
    public static void Main()
    {
        // Crie um programa que leia 10 valores double e salve em um array, depois imprima esses valores

        int contador;
        double[] vetor;
        vetor = new double[10];

        Console.WriteLine("Informe 10 valores");

        for (contador = 0; contador < 10; contador++)
        {
            Console.WriteLine("Informe o " + (contador + 1) + "º valor: ");
            vetor[contador] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Números informados: ");
        foreach (double valores in vetor)
        {
            Console.WriteLine(valores);
        }
    }
}