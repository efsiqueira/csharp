using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Models
{
    public class Especialidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Detalhamento { get; set; }

        public ICollection<Dentista> Dentistas { get; set; }

        public Especialidade() { }

        public Especialidade(
            string Descricao,
            string Detalhamento
        )
        {
            this.Descricao = Descricao;
            this.Detalhamento = Detalhamento;

            Context db = new Context();
            db.Especialidades.Add(this);
            db.SaveChanges();
        }

        public override string ToString()
        {
            return $"ID: {this.Id}"
                + $"\nDescrição: {this.Descricao}"
                + $"\nDetalhamento: {this.Detalhamento}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!Especialidade.ReferenceEquals(obj, this))
            {
                return false;
            }
            Especialidade it = (Especialidade) obj;
            return it.Id == this.Id;
        }

        public static IEnumerable<Especialidade> GetEspecialidades()
        {
            Context db = new Context();
            return from Especialidade in db.Especialidades select Especialidade;
        }

        public static void RemoverEspecialidade(
            Especialidade especialidade
        )
        {
            Context db = new Context();
            db.Especialidades.Remove(especialidade);
            db.SaveChanges();
        }

    }
}