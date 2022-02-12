using System;

public class TerceiroExercicio
{
    public static void Main()
    {
        // Crie um programa que receba a altera e o peso e calcule o IMC

        double altura = 0.0, peso = 0.0, imc = 0.0;
        string resultadoImc = "";

        Console.WriteLine("Informe sua altura (em metros): ");
        altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe seu peso (em quilos): ");
        peso = Convert.ToDouble(Console.ReadLine());

        imc = peso / (altura * altura);

        if(imc <= 18.5)
        {
            resultadoImc = "abaixo do peso";
        }
        else if(imc <= 24.9)
        {
            resultadoImc = "no peso ideal";
        }
        else if(imc <= 29.9)
        {
            resultadoImc = "levemente acima do peso";
        }
        else if(imc <= 34.9)
        {
            resultadoImc = "na obesidade Grau I";
        }
        else if(imc <= 39.9)
        {
            resultadoImc = "na obesidade Grau II";
        }
        else
        {
            resultadoImc = "na obesidade Grau III (mórbida)";
        }

        Console.WriteLine("Seu IMC é: " + imc + " e você está " + resultadoImc);

    }
}