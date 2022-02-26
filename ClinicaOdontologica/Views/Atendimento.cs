using System;
using Controllers;
using Models;

namespace Views
{
    public class AtendimentoView
    {
        public static void InserirAtendimento()
        {
            int IdAgendamento;
            int IdProcedimento;
            Console.WriteLine("Digite o Id do Agendamento: ");
            try
            {
                IdAgendamento = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Id inválido.");
            }
            try
            {
                IdProcedimento = Convert.ToInt32("Digite o Id do Procedimento: ");
            }
            catch
            {
                throw new Exception("Id inválido.");
            }

            AtendimentoController.InserirAtendimento(
                IdAgendamento,
                IdProcedimento
            );

        }

        public static void ExcluirAgendamento()
        {
            int Id = 0;
            Console.WriteLine("Digite o Id do Atendimento: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Id inválido.");
            }

            AtendimentoController.ExcluirAtendimento(
                Id
            );
        }

        public static void ListarAtendimento()
        {
            foreach (Atendimento item in AtendimentoController.VisualizarAtendimentos())
            {
                Console.WriteLine(item);
            }
        }
    }
}