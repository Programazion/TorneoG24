using Torneo.App.Dominio; /// Se añade IRepositorioPartido
namespace Torneo.App.Persistencia
{
    public interface IRepositorioPartido
    {
        public Partido AddPartido(int Id , DateTime FechaHora, Local Equipo, int MarcadorLocal, Visitante Equipo, int MarcadorVisitante);     
    
         public IEnumerable<Partido> GetAllPartidos();///Añadí GetAllPartidos
            
    }
}