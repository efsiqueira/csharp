using System;
using Controllers;
using Models;

namespace Views
{
    public class EspecialidadeView
    {
        public static void InserirEspecialidade()
        {
            Console.WriteLine("Digite a Descrição da Especialidade: ");
            string Descricao = Console.ReadLine();
            Console.WriteLine("Digite o Detalhamento da Especialidade: ");
            string Detalhamento = Console.ReadLine();

            EspecialidadeController.InserirEspecialidade(
                Descricao,
                Detalhamento
            );
        }

        public static void AlterarEspecialidade()
        {
            int Id = 0;
            Console.WriteLine("Digite o Id da Especialidade: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Id inválido.");
            }
            Console.WriteLine("Digite a Descrição da Especialidade: ");
            string Descricao = Console.ReadLine();
            Console.WriteLine("Digite o Detalhamento da Especialidade: ");
            string Detalhamento = Console.ReadLine();

            EspecialidadeController.AlterarEspecialidade(
                Id,
                Descricao,
                Detalhamento
            );
        }

        public static void ExcluirEspecialidade()
        {
            int Id = 0;
            Console.WriteLine("Digite o Id da Especialidade");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Id inválido.");
            }

            EspecialidadeController.ExcluirEspecialidade(
                Id
            );
        }

        public static void ListarEspecialidade()
        {
            foreach (Especialidade item in EspecialidadeController.VisualizarEspecialidade())
            {
                Console.WriteLine(item);
            }
        }
    }
}