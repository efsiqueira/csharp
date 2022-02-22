using System;
using System.Collections.Generic;

namespace Models
{
    public class Paciente : Pessoa
    {
        public static int ID = 0;
        private static List<Paciente> Pacientes = new List<Paciente>();
        public DateTime DataNascimento { get; set; }

        public override string ToString()
        {
            return base.ToString()
                + $"\nData de Nascimento: {this.DataNascimento}";
        }

        public Paciente(
            string Nome,
            string Cpf,
            string Fone,
            string Email,
            DateTime DataNascimento
        ) : this(++ID, Nome, Cpf, Fone, Email, DataNascimento)
        {}
        
        private Paciente(
            int Id,
            string Nome,
            string Cpf,
            string Fone,
            string Email,
            DateTime DataNascimento
        ) : base(Id, Nome, Cpf, Fone, Email)
        {
            this.DataNascimento = DataNascimento;

            Pacientes.Add(this);
        }

        public static List<Paciente> GetPacientes()
        {
            return Pacientes;
        }

        public static void RemoverPaciente(Paciente paciente)
        {
            Pacientes.Remove(paciente);
        }
    }
}