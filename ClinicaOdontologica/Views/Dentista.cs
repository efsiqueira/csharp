using System;
using Controllers;
using Models;

namespace Views
{
    public class DentistaView
    {
        public static void InserirDentista()
        {   
            double Salario = 0;
            Console.WriteLine("Digite o Nome do Dentista: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do Dentista: ");
            string Cpf = Console.ReadLine();
            Console.WriteLine("Digite o Telefone do Dentista: ");
            string Fone = Console.ReadLine();
            Console.WriteLine("Digite o Email do Dentista: ");
            string Email = Console.ReadLine();
            Console.WriteLine("Digite a Senha do Dentista: ");
            string Senha = Console.ReadLine();
            Console.WriteLine("Digite o Número do CRO: ");
            string Registro = Console.ReadLine();
            Console.WriteLine("Digite o Salário do Dentista: ");
            try
            {
               Salario = Convert.ToDouble(Console.ReadLine()); 
            }
            catch (System.Exception)
            {
                throw new Exception("Salário inválido.");
            }
            
            Console.WriteLine("Digite a Especialidade do Dentista: ");
            int IdEspecialidade = Convert.ToInt32(Console.ReadLine());
            
            DentistaController.InserirDentista(
                Nome,
                Cpf,
                Fone,
                Email,
                Senha,
                Registro,
                Salario,
                IdEspecialidade
            );
        }

        public static void AlterarDentista()
        {   
            int Id = 0;
            double Salario = 0;
            Console.WriteLine("Digite o Id do Dentista: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());   
            }
            catch
            {
                throw new Exception("Id inválido.");
            }
            Console.WriteLine("Digite o Nome do Dentista: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do Dentista: ");
            string Cpf = Console.ReadLine();
            Console.WriteLine("Digite o Telefone do Dentista: ");
            string Fone = Console.ReadLine();
            Console.WriteLine("Digite o Email do Dentista: ");
            string Email = Console.ReadLine();
            Console.WriteLine("Digite a Senha do Dentista: ");
            string Senha = Console.ReadLine();
            Console.WriteLine("Digite o Número do CRO: ");
            string Registro = Console.ReadLine();
            Console.WriteLine("Digite o Salário do Dentista: ");
            try
            {
               Salario = Convert.ToDouble(Console.ReadLine()); 
            }
            catch (System.Exception)
            {
                throw new Exception("Salário inválido.");
            }
            
            Console.WriteLine("Digite a Especialidade do Dentista: ");
            int IdEspecialidade = Convert.ToInt32(Console.ReadLine());
            
            DentistaController.AlterarDentista(
                Id,
                Nome,
                Cpf,
                Fone,
                Email,
                Senha,
                Registro,
                Salario,
                IdEspecialidade
            );
        }

        public static void ExcluirDentista()
        {   
            int Id = 0;
            Console.WriteLine("Digite o Id do Dentista: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());   
            }
            catch (System.Exception)
            {
                throw new Exception("Id inválido.");
            }
            
            DentistaController.ExcluirDentista(
                Id
            );
        }

        public static void ListarDentistas()
        {
            foreach (Dentista item in DentistaController.VisualizarDentista())
            {
                Console.WriteLine(item);
            }
        }
    }
}