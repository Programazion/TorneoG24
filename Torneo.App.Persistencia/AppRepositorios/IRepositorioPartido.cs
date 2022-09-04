using Torneo.App.Dominio; /// Se añade IRepositorioPartido
namespace Torneo.App.Persistencia
{
    public interface IRepositorioPartido
    {
        public Partido AddPartido(int Id , DateTime FechaHora, string Local, int MarcadorLocal, string  Visitante, int MarcadorVisitante);     
    
         public IEnumerable<Partido> GetAllPartidos();///Añadí GetAllPartidos
            
    }
}