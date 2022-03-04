using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Repository;

namespace Models
{
    public class Paciente : Pessoa
    {
        [Required]
        public DateTime DataNascimento { get; set; }

        public ICollection<Agendamento> Agendamentos { get; set; }

        public override string ToString()
        {
            return base.ToString()
                + $"\nData de Nascimento: {this.DataNascimento}";
        }

        public Paciente() { }
        public Paciente(
            string Nome,
            string Cpf,
            string Fone,
            string Email,
            string Senha,
            DateTime DataNascimento
        ) : base(Nome, Cpf, Fone, Email, Senha)
        {
            this.DataNascimento = DataNascimento;

            Context db = new Context();
            db.Pacientes.Add(this);
            db.SaveChanges();
        }

        public static IEnumerable<Paciente> GetPacientes()
        {
            Context db = new Context();
            return (from Paciente in db.Pacientes select Paciente);
        }

        public static void RemoverPaciente(Paciente paciente)
        {
            Context db = new Context();
            db.Pacientes.Remove(paciente);
            db.SaveChanges();
        }

        public static Paciente VerifyLogin(
            string Email,
            string Senha
        )
        {
            try
            {
                return GetPacientes().First(Paciente => Paciente.Email == Email 
                    && BCrypt.Net.BCrypt.Verify(Senha, Paciente.Senha));
            }
            catch
            {
                return null;    
            }
        }
    }
}