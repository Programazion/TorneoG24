using Microsoft.EntityFrameworkCore;///Se añade RepositorioPartido
using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public class RepositorioPartido : IRepositorioPartido
    {
        private readonly DataContext _dataContext = new DataContext();
        public Partido AddPartido(Partido Partido)
        {
            var PartidoInsertado = _dataContext.Partido.Add(Partido);
            _dataContext.SaveChanges();
            return PartidoInsertado.Entity;
        }
    }
}