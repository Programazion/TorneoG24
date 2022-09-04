using Torneo.App.Dominio;///Se añade IrepositorioEquipo
namespace Torneo.App.Persistencia
{
    public interface IRepositorioEquipo
    {
        public Equipo AddEquipo(Equipo equipo, int idMunicipio, int idDT);
        public IEnumerable<Equipo> GetAllEquipos();

        
    }
}