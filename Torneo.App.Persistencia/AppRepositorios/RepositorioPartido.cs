using System;
using Microsoft.EntityFrameworkCore;///Se añade RepositorioPartido
using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public class RepositorioPartido : IRepositorioPartido
    {
        private readonly DataContext _dataContext = new DataContext(); /// Se sumaron los parámetros
        public Partido AddPartido(Partido partido, int idLocal, int idVisitante)
        ///public Partido AddPartido(Partido partido, DateTime FechaHora, Equipo Local, int MarcadorLocal, Equipo Visitante , int MarcadorVisitante)
        {
            DateTime FechaHora = _dataContext.DateTime.Find(FechaHora);//Revisar 
             Partido.FechaHora = FechaHora; //Revisar

            var equipoLocalEncontrado = _dataContext.Partidos.Find(Local); //Revisar 
            Equipo Partido = _dataContext.Partido.Find(Local); //Revisar este cambio 

            /*var marcadorLocalEncontrado = _dataContext.Partidos.Find(MarcadorLocal);///Revisar 
            Partido.MarcadorLocal = marcadorLocalEncontrado; ///Revisar*/

            var equipoVisitanteEncontrado = _dataContext.Partidos.Find(Visitante); //Revisar 
            Equipo Partido = _dataContext.Partido.Find(Local); //Revisar este cambio

            /*var marcadorVisitanteEncontrado = _dataContext.Partidos.Find(MarcadorVisitante);///Revisar 
            Partido.MarcadorVisitante = marcadorVisitanteEncontrado; ///Revisar*/

            var PartidoInsertado = _dataContext.Partidos.Add(partido);
            _dataContext.SaveChanges();
            return PartidoInsertado.Entity;
        }
       
        public IEnumerable<Partido> GetAllPartidos()
        {
            var partidos = _dataContext.Partidos
                .Include(e => e.Equipo)
                .Include(e => e.Equipo)
                .ToList();
            return partidos;
        }
    }
}