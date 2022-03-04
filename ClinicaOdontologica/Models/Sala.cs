using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Repository;

namespace Models
{
    public class Sala
    {
        public int Id { get; set; }
        [Required]
        public string Numero { get; set; }
        [Required]
        public string Equipamentos { get; set; }
        public ICollection<Agendamento> Agendamentos { get; set; }

        public Sala() { }
        public Sala(
            string Numero,
            string Equipamentos
        )
        {
            this.Numero = Numero;
            this.Equipamentos = Equipamentos;

            Context db = new Context();
            db.Salas.Add(this);
            db.SaveChanges();
        }

        public override string ToString()
        {
            return $"ID: {this.Id}"
                + $"\nNúmero: {this.Numero}"
                + $"\nEquipamentos: {this.Equipamentos}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!Sala.ReferenceEquals(obj, this))
            {
                return false;
            }
            Sala it = (Sala) obj;
            return it.Id == this.Id;
        }

        public static IEnumerable<Sala> GetSalas()
        {
            Context db = new Context();
            return from Sala in db.Salas select Sala;
        }

        public static void RemoverSala(Sala sala)
        {
            Context db = new Context();
            db.Salas.Remove(sala);
            db.SaveChanges();
        }
    }
}