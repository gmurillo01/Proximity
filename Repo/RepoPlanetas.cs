using ProximityCR_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProximityCR_API.Repo
{
    public class RepoPlanetas
    {

        public static List<Planetas> _listaPlanetas = new List<Planetas>()
        {
            new Planetas() { Id = 1, Nombre = "Mercurio" },
            new Planetas() { Id = 2, Nombre = "Venus" },
            new Planetas() { Id = 3, Nombre = "Tierra"},
            new Planetas() { Id = 4, Nombre = "Marte"},
            new Planetas() { Id = 5, Nombre = "Jupiter"},
            new Planetas() { Id = 6, Nombre = "Saturno"},
            new Planetas() { Id = 7, Nombre = "Urano"},
            new Planetas() { Id = 8, Nombre = "Neptuno"}
        };

        public IEnumerable<Planetas> ObtenerPlanetas()
        {
            return _listaPlanetas;
        }

        public Planetas ObtenerPlaneta(int id)
        {
            var plan = _listaPlanetas.Where(planeta => planeta.Id == id);

            return plan.FirstOrDefault();
        }

        public void Agregar(Planetas nuevoPlaneta)
        {
            _listaPlanetas.Add(nuevoPlaneta);
        }
    }
}
