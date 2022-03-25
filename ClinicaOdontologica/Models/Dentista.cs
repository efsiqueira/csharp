using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace Models
{
    public class Dentista : Pessoa
    {
        [Required]
        public string Registro { get; set; }
        public double Salario { get; set; }
        public int EspecialidadeId { get; set; }
        public Especialidade Especialidade { get; set; }

        public ICollection<Agendamento> Agendamentos { get; set; }


        public override string ToString()
        {
            return base.ToString()
                + $"\nRegistro (CRO): {this.Registro}"
                + $"\nSalario: R$ {this.Salario}"
                + $"\nEspecialidade: {this.Especialidade.Descricao}";

        }

        public Dentista() {
        }

        public Dentista(
            string Nome,
            string Cpf,
            string Fone,
            string Email,
            string Senha,
            string Registro,
            double Salario,
            int EspecialidadeId
        ) : base(Nome, Cpf, Fone, Email, Senha)
        {
            this.Registro = Registro;
            this.Salario = Salario;
            this.EspecialidadeId = EspecialidadeId;

            Context db = new Context();
            db.Dentistas.Add(this);
            db.SaveChanges();
        }

        public static IEnumerable<Dentista> GetDentistas()
        {
            Context db = new Context();
            return db.Dentistas.Include("Especialidade");
        }

        public static void RemoverDentista(Dentista dentista)
        {
            Context db = new Context();
            db.Dentistas.Remove(dentista);
            db.SaveChanges();
        }

        public static Dentista AlterarDentista(
            int Id,
            string Nome,
            string Cpf,
            string Fone,
            string Email,
            string Senha,
            string Registro,
            double Salario,
            int EspecialidadeId
        )
        {
            Dentista dentista = GetDentista(Id);
            dentista.Nome = Nome;
            dentista.Cpf = Cpf;
            dentista.Fone = Fone;
            dentista.Email = Email;
            dentista.Senha = Senha;
            dentista.Registro = Registro;
            dentista.Salario = Salario;
            dentista.EspecialidadeId = EspecialidadeId;

            Context db = new Context();
            db.Dentistas.Update(dentista);
            db.SaveChanges();

            return dentista;
        }

        public static Dentista GetDentista(
            int Id
        )
        {
            Dentista dentista = (
                from Dentista in Dentista.GetDentistas()
                    where Dentista.Id == Id
                    select Dentista
            ).First();

            if (dentista == null)
            {
                throw new Exception("Dentista não encontrado");
            }

            return dentista;
        }

        public static Dentista VerifyLogin(
            string Email,
            string Senha
        )
        {
            
            try
            {
                return GetDentistas().First(Dentista => Dentista.Email == Email 
                    && BCrypt.Net.BCrypt.Verify(Senha, Dentista.Senha));
            }
            catch
            {
                return null;    
            }
        }
    }
}