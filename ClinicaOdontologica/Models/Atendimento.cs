using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace Models
{
    public class Atendimento
    {
        public int Id { get; set; }
        public int AgendamentoId { get; set; }
        public Agendamento Agendamento { get; }
        public int ProcedimentoId { get; set; }
        public Procedimento Procedimento { get; }
        
        public Atendimento() { }
        public Atendimento(
            int AgendamentoId,
            int ProcedimentoId
        )
        {
            this.AgendamentoId = AgendamentoId;
            this.ProcedimentoId = ProcedimentoId;
            
            Context db = new Context();
            db.Atendimentos.Add(this);
            db.SaveChanges();
        }

        public override string ToString()
        {
            return $"\nID: {this.Id}"
                + $"\nDentista: {this.Agendamento.Dentista.Nome}"
                + $"\nPaciente: {this.Agendamento.Paciente.Nome}"
                + $"\nSala: {this.Agendamento.Sala.Numero}"
                + $"\nData: {this.Agendamento.Data}"
                + $"\nProcedimento: {this.Procedimento.Descricao}"
                + $"\nValor: R$ {this.Procedimento.Preco}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!Atendimento.ReferenceEquals(obj, this))
            {
                return false;
            }
            Atendimento it = (Atendimento) obj;
            return it.Id == this.Id;
        }

        public static IEnumerable<Atendimento> GetAtendimentos()
        {
            Context db = new Context();
            return db.Atendimentos
                .Include("Agendamento")
                .Include("Procedimento");
        }

        public static void RemoverAtendimento(
            Atendimento atendimento
        )
        {
            Context db = new Context();
            db.Atendimentos.Remove(atendimento);
            db.SaveChanges();
        }
    }
}