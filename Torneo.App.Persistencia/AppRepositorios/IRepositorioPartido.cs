using Torneo.App.Dominio; /// Se añade IRepositorioPartido
namespace Torneo.App.Persistencia
{
    public interface IRepositorioPartido
    {
        public Partido AddPartido(Partido partido);
        ///, DataTime FechaHora, Local Equipo, int Marcador, Visitante Equipo);
    }
}