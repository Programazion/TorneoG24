using Torneo.App.Dominio;///Se añade IRepositorioDT
namespace Torneo.App.Persistencia
{
    public interface IRepositorioDT
    {
        public DirectorTecnico AddDT(DirectorTecnico DT);///Se añade GetAllDirectoresTecnicos

        public IEnumerable<DirectorTecnico> GetAllDirectoresTecnicos();
    }
}