using Microsoft.EntityFrameworkCore;///Se añade RepositorioPartido
using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public class RepositorioPartido : IRepositorioPartido
    {
        private readonly DataContext _dataContext = new DataContext(); /// Se sumaron los parámetros
        public Partido AddPartido(Partido Partido, int Id , DateTime FechaHora, Equipo Local, int MarcadorLocal, Equipo Visitante , int MarcadorVisitante)
        {
            var fechaHoraEncontrado = _dataContext.DateTime.Find(FechaHora);//Revisar 
            Partido.FechaHora = fechaHoraEncontrado; //Revisar
            var equipoInsertado = _dataContext.Equipo.find(Local); //Revisar 
            Partido.Local = _dataContext.Equipo.Find(Local); //Revisar
            var marcadorLocalInsertado = _dataContext.Partido.Find(MarcadorLocal);///Revisar 
            Partido.MarcadorLocal = marcadorLocalInsertado; ///Revisar
            var marcadorVisitanteInsertado = _dataContext.Partido.Find(MarcadorVisitante);///Revisar 
            Partido.MarcadorVisitante = marcadorVisitanteInsertado; ///Revisar
            var PartidoInsertado = _dataContext.Partido.Add(Partido); 
            _dataContext.SaveChanges();
            return PartidoInsertado.Entity;
        }
        public IEnumerable<Partido> GetAllPartidos() ///Añadí GetAllPartidos
        {
            return _dataContext.Partidos;
        }
    }
}