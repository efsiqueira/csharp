using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Controllers
{
    public class AgendamentoController
    {
        public static Agendamento InserirAgendamento(
            int IdPaciente,
            int IdDentista,
            int IdSala,
            DateTime Data,
            string Procedimento
        )
        {
            PacienteController.GetPaciente(IdPaciente);
            DentistaController.GetDentista(IdDentista);
            SalaController.GetSala(IdSala);

            if (Data == null || Data < DateTime.Now)
            {
                throw new Exception("Data inválida");
            }

            return new Agendamento(IdPaciente, IdDentista, IdSala, Data, Procedimento);
        }

        public static Agendamento AlterarAgendamento(
            int Id,
            int IdSala,
            DateTime Data,
            string Procedimento
        )
        {
            Agendamento agendamento = GetAgendamento(Id);

            SalaController.GetSala(IdSala);

            if (Data == null || Data < DateTime.Now)
            {
                throw new Exception("Data inválida");
            }
            
            agendamento.IdSala = IdSala;
            agendamento.Data = Data;
            agendamento.Procedimento = Procedimento;

            return agendamento;
        }

        public static Agendamento ExcluirAgendamento(
            int Id
        )
        {
            Agendamento agendamento = GetAgendamento(Id);
            Agendamento.RemoverAgendamento(agendamento);
            return agendamento;
        }

        public static List<Agendamento> VisualizarAgendamento()
        {
            return Agendamento.GetAgendamentos();
        }

        public static Agendamento GetAgendamento(
            int Id
        )
        {
            Agendamento agendamento = (
                from Agendamento in Agendamento.GetAgendamentos()
                    where Agendamento.Id == Id
                    select Agendamento
            ).First();

            if (agendamento == null)
            {
                throw new Exception("Agendamento não encontrado");
            }

            return agendamento;
        }
    }
}