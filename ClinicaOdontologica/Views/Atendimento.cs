using System;
using Controllers;
using Models;

namespace Views
{
    public class AtendimentoView
    {
        public static void InserirAtendimento()
        {
            int AgendamentoId;
            int ProcedimentoId;
            Console.WriteLine("Digite o Id do Agendamento: ");
            try
            {
                AgendamentoId = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Id inválido.");
            }
            Console.WriteLine("Digite o Id do Procedimento: ");
            try
            {
                ProcedimentoId = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Id inválido.");
            }

            AtendimentoController.InserirAtendimento(
                AgendamentoId,
                ProcedimentoId
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