using Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Controllers
{
    public class SalaController
    {
        public static Sala IncluirSala(
            string Numero,
            string Equipamentos
        )
        {
            if (String.IsNullOrEmpty(Numero))
            {
                throw new Exception("Número é obrigatório");
            }

            return new Sala(Numero, Equipamentos);
        }

        public static Sala AlterarSala(
            int Id,
            string Numero,
            string Equipamentos
        )
        {
            Sala sala = GetSala(Id);

            if (!String.IsNullOrEmpty(Numero))
            {
                sala.Numero = Numero;
            }
            sala.Equipamentos = Equipamentos;

            return sala;
        }

        public static Sala ExcluirSala(
            int Id
        )
        {
            Sala sala = GetSala(Id);
            Sala.RemoverSala(sala);

            return sala;
        }

        public static IEnumerable<Sala> VisualizarSala()
        {
            return Sala.GetSalas();
        }

        public static Sala GetSala(
            int Id
        )
        {
            Sala sala = Models.Sala.GetSalas().First(Sala => Sala.Id == Id);
            
            if (sala == null)
            {
                throw new Exception("Sala não encontrada");
            }

            return sala;
        }
    }
}