﻿using Torneo.App.Dominio; ///Mi Proyecto personal
using Torneo.App.Persistencia;
namespace Torneo.App.Consola
{
    class Program
    {
        private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        private static IRepositorioDT _repoDT = new RepositorioDT();
        private static IRepositorioEquipo _repoEquipo = new RepositorioEquipo(); ///Añadir Jugador y partido

        static void Main(string[] args) ///Añadir Menú do While 
        {
             int opcion = 0;
            do{
                Console.WriteLine("1. Insertar municipio");
                Console.WriteLine("2. Insertar director tecnico");
                Console.WriteLine("3. Insertar equipo");
                Console.WriteLine("4. Mostrar municipios");
                Console.WriteLine("5. Mostrar DTs");
                Console.WriteLine("6. Mostrar Equipos");/// Insertar la opción Jugador - posición Partido
                Console.WriteLine("7. Mostrar Partidos");/// Se insertó Partidos
                Console.WriteLine("0. Salir");
                Console.WriteLine("Seleccione la opcion deseada");
                opcion = Int32.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        AddMunicipio();
                        break;
                    case 2:
                        AddDT();
                        break;
                    case 3:
                        AddEquipo();
                        break;
                    case 4:
                        GetAllMunicipios();
                        break;
                    case 5:
                        GetAllDTs();
                        break;
                    case 6:
                        GetAllEquipos();
                        break;          

                    case 7: 
                        GetAllPartidos();///Se añadió la opción GETAllPartidos();
                        break;

                    
                }
            } while(opcion != 0);
        }

        private static void AddMunicipio()
        {
            Console.WriteLine("Escriba el nombre del municipio");
            string nombre = Console.ReadLine();
            var municipio = new Municipio
            {
                Nombre = nombre,
            };
            _repoMunicipio.AddMunicipio(municipio);
        }

        private static void AddDT()
        {
            Console.WriteLine("Escriba el nombre del DT");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba el documento del DT");
            string documento = Console.ReadLine();
            Console.WriteLine("Escriba el telefono del DT");
            string telefono = Console.ReadLine();
            var directorTecnico = new DirectorTecnico
            {
                Nombre = nombre,
                Documento = documento,
                Telefono = telefono,
            };
            _repoDT.AddDT(directorTecnico);
        }

        private static void AddEquipo() ///Añadir AddJugador() y AddPartido()
        {
            Console.WriteLine("Escriba el nombre del equipo");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba el id del municipio");
            int idMunicipio = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el id del DT");
            int idDT = Int32.Parse(Console.ReadLine());

            var equipo = new Equipo
            {
                Nombre = nombre,
            };
            _repoEquipo.AddEquipo(equipo, idMunicipio, idDT);
        }

        private static void AddPartido() ///Añadí menu Partido
        {
            Console.WriteLine("Escriba la fecha del partido");
            DateTime fechaHora = Console.ReadLine();
            Console.WriteLine("Escriba el id del equipo local");
            int idLocal = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el id del equipo visitante");
            int idVisitante = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el marcador del equipo Local");
            int marcadorLocal = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el marcador del equipo Local");
            int marcadorVisitante = Int32.Parse(Console.ReadLine());

            var partido = new Partido
            {
                FechaHora = fechaHora,
                IdLocal = local,
                IdVisitante = idvisitante,
                MarcadorLocal = marcadorLocal,
                MarcadorVisitante = marcadorVisitante,

            };
            _repoEquipo.AddPartido(fechaHora, idlocal, idvisitante, marcadorLocal, marcadorVisitante);
        } 

        private static void GetAllMunicipios()
        {
            foreach (var municipio in _repoMunicipio.GetAllMunicipios())
            {
                Console.WriteLine(municipio.Id + " " + municipio.Nombre);
            }
        }

        private static void GetAllDTs()
        {
            foreach (var dt in _repoDT.GetAllDTs())
            {
                Console.WriteLine(dt.Id + " " + dt.Nombre + " " + dt.Documento + " " + dt.Telefono);
            }
        }

        private static void GetAllEquipos()
        {
            foreach (var equipo in _repoEquipo.GetAllEquipos())
            {
                Console.WriteLine(equipo.Id + " " + equipo.Nombre 
                + " " + equipo.Municipio.Nombre + " " + equipo.DirectorTecnico.Nombre);
            }
        }

        ///Se añade Método GeAllPartidos() Daniel Sánchez
        private static void GetAllPartidos()
        {
            foreach (var partido in _repoPartido.GetAllPartidos())
            {
                Console.WriteLine(fechaHora.DateTime + "DD-MM-YYYY" + local.Id + " " + marcadorLocal.equipo + " " + visitante.Id + " " + marcadorVisitante.equipo + " "  );
            }
        }



    }
}