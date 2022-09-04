using Torneo.App.Dominio; /// Se añade IRepositorioPartido
namespace Torneo.App.Persistencia
{
    public interface IRepositorioPartido
    {
        public Partido AddPartido(Partido partido, int idLocal, int idVisitante);
        ///(Partido partido, DateTime FechaHora, Equipo Local, int MarcadorLocal, Equipo  Visitante, int MarcadorVisitante)
         public IEnumerable<Partido> GetAllPartidos();///Añadí GetAllPartidos
            
    }
}