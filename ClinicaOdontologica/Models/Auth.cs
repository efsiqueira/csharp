using System.Linq;

namespace Models
{
    public class Auth
    {
        public static Paciente Paciente;
        public static Dentista Dentista;

        public static bool isLogged;

        public static void Login(
            string Email,
            string Senha
        )
        {
            Paciente paciente = Paciente.VerifyLogin(Email, Senha);

            if (paciente != null)
            {
                System.Console.WriteLine(paciente.Senha);
                isLogged = true;
                Paciente = paciente;
                Dentista = null;
            }
            else
            {
                Dentista dentista = Dentista.VerifyLogin(Email, Senha);
                System.Console.WriteLine(dentista.Senha);
                if (dentista != null)
                {
                    isLogged = true;
                    Dentista = dentista;
                    Paciente = null;
                }
                else
                {
                    Logout();
                    throw new System.Exception("Login inválido");
                }
            }
        }

        public static void Logout()
        {
            isLogged = false;
            Dentista = null;
            Paciente = null;
        }
    }
}