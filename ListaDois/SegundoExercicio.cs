using System;

public class SegundoExercicio
{
    public static void Main()
    {
        /* Crie um programa que tenha como entrada as notas de um aluno. Somente se encerrará
        quando for inserida uma nota negativa. Ao final deverá informar a média das notas */

        double nota = 0.0, soma = 0.0;
        int quantidadeNotas = 0;

        do {
            Console.WriteLine("Informe a " + (quantidadeNotas + 1) + " ª nota do aluno: ");
            nota = Convert.ToInt32(Console.ReadLine());
            soma += nota;
            quantidadeNotas++;
        } while(nota >= 0);

        Console.WriteLine("A média das notas informadas é: " + ((soma - nota)/(quantidadeNotas-1)));

    }
}