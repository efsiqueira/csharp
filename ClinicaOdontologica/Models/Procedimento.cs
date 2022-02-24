using System;
using System.Collections.Generic;

namespace Models
{
    public class Procedimento
    {
        public static int ID = 0;
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Procedimento(
            string Descricao,
            double Preco
        )
        {
            this.Descricao = Descricao;
            this.Preco = Preco;
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
    }
}