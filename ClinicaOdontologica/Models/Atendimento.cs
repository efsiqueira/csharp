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
        public Procedimento Procedimento { get; }
        public int IdProcedimento { get; set; }

        public Atendimento(
            int IdAgendamento,
            int IdProcedimento,
            Atendimento Atendimento,
            Procedimento Procedimento
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
            this.IdProcedimento = IdProcedimento;
            this.Agendamento = Agendamento.GetAgendamentos().Find(Agendamento => Agendamento.Id == IdAgendamento);
            // Criar o getprocedimentos
            //this.Procedimento = Procedimento.GetProcedimentos().Find(Procedimento => Procedimento.Id == IdProcedimento);

            Atendimentos.Add(this);
        }

        public override string ToString()
        {
            return $"\nID: {this.Id}"
                + $"\n";
        }
    }
}