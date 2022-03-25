using System;
using System.Collections.Generic;
using System.Linq;
using Models;
using System.Text.RegularExpressions;

namespace Controllers
{
    public class DentistaController
    {
        public static Dentista InserirDentista(
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
            EspecialidadeController.GetEspecialidade(EspecialidadeId);

            if (String.IsNullOrEmpty(Nome))
            {
                throw new Exception("Nome inválido");
            }
            Regex rx = new Regex("(^\\d{3}\\.\\d{3}\\.\\d{3}\\-\\d{2}$)|(^\\d{2}\\.\\d{3}\\.\\d{3}\\/\\d{4}\\-\\d{2}$)");
            if (String.IsNullOrEmpty(Cpf) || !rx.IsMatch(Cpf))
            {
                throw new Exception("CPF inválido");
            }
            if (String.IsNullOrEmpty(Fone))
            {
                throw new Exception("Fone inválido");
            }
            if (String.IsNullOrEmpty(Email))
            {
                throw new Exception("Email inválido");
            }
            if (String.IsNullOrEmpty(Senha))
            {
                throw new Exception("Senha inválida");
            }
            else
            {
                Senha = BCrypt.Net.BCrypt.HashPassword(Senha);
            }

            if (String.IsNullOrEmpty(Registro))
            {
                throw new Exception("Registro inválido");
            }

            return new Dentista(Nome, Cpf, Fone, Email, Senha, Registro, Salario, EspecialidadeId);
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
            Especialidade especialidade = EspecialidadeController.GetEspecialidade(EspecialidadeId);

            if (String.IsNullOrEmpty(Nome))
            {
                Nome = dentista.Nome;
            }
            if (String.IsNullOrEmpty(Cpf))
            {
                Cpf = dentista.Cpf;
            }
            if (String.IsNullOrEmpty(Fone))
            {
                Fone = dentista.Fone;
            }
            if (String.IsNullOrEmpty(Email))
            {
                Email = dentista.Email;
            }
            if (!String.IsNullOrEmpty(Senha) && !BCrypt.Net.BCrypt.Equals(Senha,dentista.Senha))
            {
                Senha = BCrypt.Net.BCrypt.HashPassword(Senha);
            }
            else
            {
                Senha = dentista.Senha;
            }
            if (String.IsNullOrEmpty(Registro))
            {
                Registro = dentista.Registro;
            }

            if (Salario <= 0) {
                Salario = dentista.Salario;
            }

            Dentista.AlterarDentista(
                Id,
                Nome,
                Cpf,
                Fone,
                Email,
                Senha,
                Registro,
                Salario,
                especialidade.Id
            );

            return dentista;

        }

        public static Dentista ExcluirDentista(
            int Id
        )
        {
            Dentista dentista = GetDentista(Id);
            Dentista.RemoverDentista(dentista);
            return dentista;
        }

        public static IEnumerable<Dentista> VisualizarDentista()
        {
            return Dentista.GetDentistas();
        }

        public static Dentista GetDentista(
            int Id
        )
        {
            return Dentista.GetDentista(Id);
        }
    }
}