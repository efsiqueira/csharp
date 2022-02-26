using System;
using Controllers;
using Models;

namespace Views
{
    public class ProcedimentoView
    {
        public static void InserirProcedimento()
        {
            Console.WriteLine("Digite a Descrição do Procedimento: ");
            string Descricao = Console.ReadLine();
            Console.WriteLine("Digite o Preço do Procedimento: ");
            double Preco = Convert.ToDouble(Console.ReadLine());

            ProcedimentoController.InserirProcedimento(
                Descricao,
                Preco
            );
        }

        public static void AlterarProcedimento()
        {
            int Id = 0;
            Console.WriteLine("Digite o Id do Procedimento: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Id inválido.");
            }
            Console.WriteLine("Digite a Descrição do Procedimento: ");
            string Descricao = Console.ReadLine();
            Console.WriteLine("Digite o Preço do Procedimento: ");
            double Preco = Convert.ToDouble(Console.ReadLine());

            ProcedimentoController.AlterarProcedimento(
                Id,
                Descricao,
                Preco
            );
        }

        public static void ExcluirProcedimento()
        {
            int Id = 0;
            Console.WriteLine("Digite o Id do Procedimento: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Id inválido.");
            }

            ProcedimentoController.ExcluirProcedimento(
                Id
            );
        }

        public static void ListarProcedimento()
        {
            foreach (Procedimento item in ProcedimentoController.VisualizarProcedimento())
            {
                Console.WriteLine(item);
            }
        }
    }
}