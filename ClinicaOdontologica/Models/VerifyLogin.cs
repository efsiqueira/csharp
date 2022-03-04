using System.Collections.Generic;
using System.Linq;
using Models;

namespace Models {
    public abstract class IVerifyLogin<T> where T : Pessoa
    {
        public static IEnumerable<T> GetDatabase() { return Enumerable.Empty<T>(); }

        public static T VerifyLogin(
            string Email,
            string Senha
        )
        {
            return GetDatabase().First(Paciente => Paciente.Email == Email 
                && BCrypt.Net.BCrypt.Verify(Senha, Paciente.Senha));
        }


    }
}