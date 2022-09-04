using Microsoft.EntityFrameworkCore;///Se añade RepositorioPartido
using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public class RepositorioPartido : IRepositorioPartido
    {
        private readonly DataContext _dataContext = new DataContext(); /// Se sumaron los parámetros
        public Partido AddPartido(Partido Partido, int Id , DateTime FechaHora, string Local, int MarcadorLocal, string Visitante , int MarcadorVisitante)
        {
            var fechaHoraEncontrado = _dataContext.DateTime.Find(FechaHora);//Revisar 
            Partido.FechaHora = fechaHoraEncontrado; //Revisar
            var equipoInsertado = _dataContext.Partidos.find(Local); //Revisar 
            Partido.Local = _dataContext.Partido.Find(Local); //Revisar
            var marcadorLocalInsertado = _dataContext.Partidos.Find(MarcadorLocal);///Revisar 
            Partido.MarcadorLocal = marcadorLocalInsertado; ///Revisar
            var marcadorVisitanteInsertado = _dataContext.Partidos.Find(MarcadorVisitante);///Revisar 
            Partido.MarcadorVisitante = marcadorVisitanteInsertado; ///Revisar
            var PartidoInsertado = _dataContext.Partidos.Add(Partido); 
            _dataContext.SaveChanges();
            return PartidoInsertado.Entity;
        }
        public IEnumerable<Partido> GetAllPartidos() ///Añadí GetAllPartidos
        {
            return _dataContext.Partidos;
        }
    }
}