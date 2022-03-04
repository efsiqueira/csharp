using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Repository;

namespace Models
{
    public class Procedimento
    {
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public double Preco { get; set; }
        public ICollection<Atendimento> Atendimentos { get; set; }

        public Procedimento() { }
        public Procedimento(
            string Descricao,
            double Preco
        )
        {
            this.Descricao = Descricao;
            this.Preco = Preco;

            Context db = new Context();
            db.Procedimentos.Add(this);
            db.SaveChanges();
        }

        public override string ToString()
        {
            return $"Id: {this.Id}"
                + $"\nDescrição: {this.Descricao}"
                + $"\nPreço: {this.Preco}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!Procedimento.ReferenceEquals(obj, this))
            {
                return false;
            }
            Procedimento it = (Procedimento) obj;
            return it.Id == this.Id;
        }

        public static IEnumerable<Procedimento> GetProcedimentos()
        {
            Context db = new Context();
            return from Procedimento in db.Procedimentos select Procedimento;
        }

        public static void RemoverProcedimento(
            Procedimento procedimento
        )
        {
            Context db = new Context();
            db.Procedimentos.Remove(procedimento);
            db.SaveChanges();
        }
    }
}