using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
      private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
      private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
      private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
      //  private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
      //  private static IRepositorioVisitaPyP _repoDueno = new RepositorioDueno(new Persistencia.AppContext());


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World vamos a trabajar con tablas");

            //ListarDuenosFiltro();
           // AddDueno();
            //BuscarDueno(5);

            //ListarVeterinariosFiltro();
           // AddVeterinario();
            //BuscarVeterinario(1);
            //AddHistoria();

           // ListarMascotasFiltro();
           // AddMascota();
            BuscarMascota();
            //AddHistoria();
            
        } 

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Juan",
                Apellidos = "Sin Miedo",
                Direccion = "Bajo un puente",
                Telefono = "1234567891",
                Correo = "juansinmiedo@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

         private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                //Cedula = "1212",
                Nombres = "Carlos",
                Apellidos = "Terrible",
                Direccion = "Sobre el puente",
                Telefono = "3214567891",
                TarjetaProfesional = 12345
            };
            _repoVeterinario.AddVeterinario(veterinario);

        }
        
         private static void AddMascota()
        {
            var mascota = new Mascota
            {
                //Cedula = "1212",
                Nombre = "Rintin Tin",
                Raza = "Pastor",
                Especie = "Canino",
                Color = "BlancoyNegro",
                
            };
            _repoMascota.AddMascota(mascota);

        }

         private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre+""+mascota.Raza+""+mascota.Especie+""mascota.Color);
          
        }

       /*  private static void AddMascota()
        {
            var mascota = new Mascota
            {
                //Cedula = "1212",
                Nombre = "PingPong",
                Raza = "Labrador",
                Especie = "Canino",
                Color = "AmarilloyBlanco",
                
            };
            _repoMascota.AddMascota(mascota);

        }

         private static void AddMascota()
        {
            var mascota = new Mascota
            {
                //Cedula = "1212",
                Nombre = "PingPong",
                Raza = "Labrador",
                Especie = "Canino",
                Color = "AmarilloyBlanco",
                
            };
            _repoMascota.AddMascota(mascota);

        }
         
          private static void AddMascota()
        {
            var mascota = new Mascota
            {
                //Cedula = "1212",
                Nombre = "Torbellino",
                Raza = "GoldenRetriever",
                Especie = "Canino",
                Color = "BrownWhite",
                
            };
            _repoMascota.AddMascota(mascota);

        }
         
            private static void AddMascota()
        {
            var mascota = new Mascota
            {
                //Cedula = "1212",
                Nombre = "Terremoto TSunami",
                Raza = "Pincher",
                Especie = "Canino",
                Color = "Caney",
                
            };
            _repoMascota.AddMascota(mascota);

        }

            private static void AddMascota()
        {
            var mascota = new Mascota
            {
                //Cedula = "1212",
                Nombre = "Candela",
                Raza = "Buldog",
                Especie = "Canino",
                Color = "NegroRojizo",
                
            };
            _repoMascota.AddMascota(mascota);

        }

*/

    }
}
    

       
       // private static void AddHistoria()
       // {
        //    var Historia = new Historia
          //  {
          //      FechaInicial= 1997-07-23,
            //    VisitasPyP= "Rodriguez", 
            //    Direccion = "Calle 120",
           //     Telefono = "111258258",
           //     Correo = "Batman@gmail.com"
          //  };
         //   _repoHistoria.AddHistoria(historia);

        //}
        
    //}       
       
//}       
       
       
       
       //instalamosen etapa de consola dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.0
       //compilamos terminal new terminal 
        //PS C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Consola>dotnet build
        //adicionamos referencia dotnet add reference ..\mascotaFeliz.App.Dominio\ enter
        // dotnet add reference ..\mascotaFeliz.App.Persistencia\ enter
        //guardamos y compilamos terminal New terminal dotnet build
        //ahora nos ubicamos en la capa de persistencia para hacer el Mapeo
        //PS C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Persistencia> 
        //dotnet ef migrations add Inicial --startup-project ..\MascotaFeliz.App.Consola\
        //en el terminal enter y aparece a la izquierda la clase Migrations del visual
        //para generarla
        //PS C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Persistencia>
        //dotnet ef database update --startup-project ..\MascotaFeliz.App.Consola\  enter
        //se genera la base de datos y nos vamos a Azure Data Studio
        //le damos new connection en el server (localDb)\MSSQLLocalDB
        //damos connect y se generan las tablas


