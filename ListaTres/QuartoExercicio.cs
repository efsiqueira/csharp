using System;

public class QuartoExercicio
{
    public static void Main()
    {
        /* Crie um program aque questione 5 perguntas:
        Telefonou a vítima?
        Esteve no local do crime?
        Mora perto da vítima?
        Devia para a vítima?
        Já trabalhou com a vítima?
        Conforme as respostas sim, deve imprimir a classificação da pessoa que respondeu:

        0-1 - Inocente
        2 - Suspeita
        3-4 - Cumplice
        5 - Assassino */

        Console.WriteLine("Estamos investigando um crime! Responde apenas com 0 - Não ou 1 - Sim");

        int resposta, somaRespostas = 0;

        string[] perguntas =
        {
            "Telefonou a vítima?",
            "Esteve no local do crime?",
            "Mora perto da vítima?",
            "Devia para a vítima?",
            "Já trabalhou com a vítima?"
        };

        foreach (string valorRespostas in perguntas)
        {
            Console.WriteLine(valorRespostas);
            resposta = int.Parse(Console.ReadLine());
            somaRespostas += resposta;
        }

        if (somaRespostas < 2)
        {
            Console.WriteLine("Inocente");
        }
        else if (somaRespostas < 3)
        {
            Console.WriteLine("Suspeito(a)");
        }
        else if (somaRespostas < 5)
        {
            Console.WriteLine("Cumplice");
        }
        else
        {
            Console.WriteLine("Assassino(a)");
        }

    }
}