namespace Models
{
    public class Pessoa : IVerifyLogin<Pessoa>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public override string ToString()
        {
            return $"ID: {this.Id}\n"
            + $"Nome: {this.Nome}\n"
            + $"C.P.F.: {this.Cpf}\n"
            + $"Telefone: {this.Fone}\n"
            + $"Email: {this.Email}";
        }

        public Pessoa() { }
        public Pessoa(
            string Nome,
            string Cpf,
            string Fone,
            string Email,
            string Senha
        )
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Fone = Fone;
            this.Email = Email;
            this.Senha = Senha;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!Pessoa.ReferenceEquals(this, obj))
            {
                return false;
            }
            Pessoa it = (Pessoa) obj;
            return it.Id == this.Id;
        }
    }
}