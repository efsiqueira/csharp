using System;
using Controllers;
using Models;

namespace Views
{
    public class AgendamentoView
    {
        public static void InserirAgendamento()
        {
            int IdPaciente;
            int IdDentista;
            int IdSala;
            DateTime Data = DateTime.Now;
            Console.WriteLine("Digite o Id do Paciente do Agendamento: ");
            try
            {
                IdPaciente = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Id inválido.");
            }
            Console.WriteLine("Digite o Id do Dentista do Agendamento: ");
            try
            {
                IdDentista = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Id inválido.");
            }
            Console.WriteLine("Digite o Id da Sala: ");
            try
            {
                IdSala = Convert.ToInt32(Console.ReadLine());
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

            Console.WriteLine("Digite os Procedimentos do Agendamento: ");
            string Procedimentos = Console.ReadLine();

            AgendamentoController.InserirAgendamento(
                IdPaciente,
                IdDentista,
                IdSala,
                Data
            );

        }

        public static void AlterarAgendamento()
        {
            int Id = 0;
            int IdSala;
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
                IdSala = Convert.ToInt32(Console.ReadLine());
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

            Console.WriteLine("Digite os Procedimentos do Agendamento: ");
            string Procedimentos = Console.ReadLine();

            AgendamentoController.AlterarAgendamento(
                Id,
                IdSala,
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

        public static void GetAgendamentosPorPaciente(int IdPaciente)
        {
            foreach (Agendamento item in AgendamentoController.GetAgendamentosPorPaciente(IdPaciente))
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