using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public virtual Paciente Paciente { get; }
        public int DentistaId { get; set; }
        public virtual  Dentista Dentista { get; }
        public int SalaId { get; set; }
        public virtual  Sala Sala { get; }
        public DateTime Data { get; set; }
        public bool Confirmado { get; set; }
        public ICollection<Atendimento> Atendimentos { get; set; }

        public Agendamento() { }
        public Agendamento(
            int PacienteId,
            int DentistaId,
            int SalaId,
            DateTime Data
        )
        {
            this.PacienteId = PacienteId;
            this.DentistaId = DentistaId;
            this.SalaId = SalaId;
            this.Data = Data;

            Context db = new Context();
            db.Agendamentos.Add(this);
            db.SaveChanges();
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

        public static IEnumerable<Agendamento> GetAgendamentos()
        {
            Context db = new Context();
            return db.Agendamentos
                .Include("Paciente")
                .Include("Dentista")
                .Include("Sala");
        }

        public static void RemoverAgendamento(
            Agendamento agendamento
        )
        {
            Context db = new Context();
            db.Agendamentos.Remove(agendamento);
            db.SaveChanges();
        }
    }
}