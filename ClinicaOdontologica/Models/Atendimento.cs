using System;
using System.Collections.Generic;

namespace Models
{
    public class Atendimento
    {
        public static int ID = 0;
        public static List<Atendimento> Atendimentos = new List<Atendimento>();
        public int Id { get; set; }
        public int IdAgendamento { get; set; }
        public Agendamento Agendamento { get; }
        public int IdProcedimento { get; set; }
        public Procedimento Procedimento { get; }
        

        public Atendimento(
            int IdAgendamento,
            int IdProcedimento
        ) : this(++ID, IdAgendamento, IdProcedimento)
        {}

        private Atendimento(
            int Id,
            int IdAgendamento,
            int IdProcedimento
        )
        {
            this.Id = Id;
            this.IdAgendamento = IdAgendamento;
            this.Agendamento = Agendamento.GetAgendamentos().Find(Agendamento => Agendamento.Id == IdAgendamento);
            this.IdProcedimento = IdProcedimento;
            this.Procedimento = Procedimento.GetProcedimentos().Find(Procedimento => Procedimento.Id == IdProcedimento);

            Atendimentos.Add(this);
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

        public static List<Atendimento> GetAtendimentos()
        {
            return Atendimentos;
        }

        public static void RemoverAtendimento(
            Atendimento atendimento
        )
        {
            Atendimentos.Remove(atendimento);
        }
    }
}