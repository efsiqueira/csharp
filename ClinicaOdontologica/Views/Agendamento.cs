using System;
using Controllers;
using Models;

namespace Views
{
    public class AgendamentoView
    {
        public static void InserirAgendamento()
        {
            int PacienteId;
            int DentistaId;
            int SalaId;
            DateTime Data = DateTime.Now;
            Console.WriteLine("Digite o Id do Paciente do Agendamento: ");
            try
            {
                PacienteId = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Id inválido.");
            }
            Console.WriteLine("Digite o Id do Dentista do Agendamento: ");
            try
            {
                DentistaId = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Id inválido.");
            }
            Console.WriteLine("Digite o Id da Sala: ");
            try
            {
                SalaId = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Id inválido.");
            }
            Console.WriteLine("Digite a Data do Agendamento: ");
            try
            {
                Data = Convert.ToDateTime(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Data inválida.");
            }

            AgendamentoController.InserirAgendamento(
                PacienteId,
                DentistaId,
                SalaId,
                Data
            );

        }

        public static void AlterarAgendamento()
        {
            int Id = 0;
            int SalaId;
            DateTime Data = DateTime.Now;
            Console.WriteLine("Digite o Id do Agendamento: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Id inválido.");
            }
            Console.WriteLine("Digite o Id da Sala do Agendamento: ");
            try
            {
                SalaId = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Id inválido.");
            }
            Console.WriteLine("Digite a Data do Agendamento: ");
            try
            {
                Data = Convert.ToDateTime(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Data inválida.");
            }

            AgendamentoController.AlterarAgendamento(
                Id,
                SalaId,
                Data
            );

        }

        public static void ExcluirAgendamento()
        {
            int Id = 0;
            Console.WriteLine("Digite o Id do Agendamento: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Id inválido.");
            }

            AgendamentoController.ExcluirAgendamento(
                Id
            );
        
        }

        public static void ListarAgendamento()
        {
            foreach (Agendamento item in AgendamentoController.VisualizarAgendamento())
            {
                Console.WriteLine(item);
            }
        }

        public static void GetAgendamentosPorPaciente(int PacienteId)
        {
            foreach (Agendamento item in AgendamentoController.GetAgendamentosPorPaciente(PacienteId))
            {
                Console.WriteLine(item);
            }
        }

        public static void ConfirmarAgendamento()
        {
            int Id = 0;
            Console.WriteLine("Digite o Id do Agendamento: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Id inválido.");
            }
            Agendamento agendamento = AgendamentoController.ConfirmarAgendamento(Id);

            Console.WriteLine("Agendamento Confirmado: ");
            Console.WriteLine(agendamento);
        }
    }
}