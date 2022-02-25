using System;
using System.Collections.Generic;

namespace Models
{
    public class Agendamento
    {
        public static int ID = 0;
        private static List<Agendamento> Agendamentos = new List<Agendamento>();
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public Paciente Paciente { get; }
        public int IdDentista { get; set; }
        public Dentista Dentista { get; }
        public int IdSala { get; set; }
        public Sala Sala { get; }
        public DateTime Data { get; set; }
        public bool Confirmado { get; set; }

        public Agendamento(
            int IdPaciente,
            int IdDentista,
            int IdSala,
            DateTime Data
        ) : this(++ID, IdPaciente, IdDentista, IdSala, Data)
        {}
        private Agendamento(
            int Id,
            int IdPaciente,
            int IdDentista,
            int IdSala,
            DateTime Data
        )
        {
            this.Id = Id;
            this.IdPaciente = IdPaciente;
            this.Paciente = Paciente.GetPacientes().Find(Paciente => Paciente.Id == IdPaciente);
            this.IdDentista = IdDentista;
            this.Dentista = Dentista.GetDentistas().Find(Dentista => Dentista.Id == IdDentista);
            this.IdSala = IdSala;
            this.Sala = Sala.GetSalas().Find(Sala => Sala.Id == IdSala);
            this.Data = Data;

            Agendamentos.Add(this);
        }

        public override string ToString()
        {
            return $"ID: {this.Id}"
                + $"\nPaciente: {this.Paciente.Nome}"
                + $"\nDentista: {this.Dentista.Nome}"
                + $"\nSala: {this.Sala.Numero}"
                + $"\nData: {this.Data}"
                + $"\nConfirmado: {(this.Confirmado ? "Sim" : "Não")}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!Agendamento.ReferenceEquals(obj, this))
            {
                return false;
            }
            Agendamento it = (Agendamento) obj;
            return it.Id == this.Id;
        }

        public static List<Agendamento> GetAgendamentos()
        {
            return Agendamentos;
        }

        public static void RemoverAgendamento(
            Agendamento agendamento
        )
        {
            Agendamentos.Remove(agendamento);
        }
    }
}