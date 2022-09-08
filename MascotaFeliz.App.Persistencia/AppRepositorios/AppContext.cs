using Microsoft.EntityFrameworkCore;    //usa  esta libreria orm
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia   //nombre de la Aplicacion y nombre del paquete
{
    public class AppContext : DbContext   //creamos clase AppContex que hereda de DbContext
    {
        public DbSet<Persona> Personas {get;set;}      //se define  propiedades de las entidades del dominio
        public DbSet<Veterinario> Veterinarios {get;set;} //maneja las entidades en la base de datos
        public DbSet<Dueno> Duenos {get;set;}             //para compilar Terminal y new Terminal
        public DbSet<VisitaPyP> VisitasPyP {get;set;}
        public DbSet<Historia> Historias {get;set;}
        public DbSet<Mascota> Mascotas {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //crea la conexion
        {
            if (!optionsBuilder.IsConfigured)  //configura la conexion con base de datos
            {
                optionsBuilder       //la base de datos se llama MascotaFelizData
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MascotaFelizData");
            } 
        }     
    }         
}


//ahora creamos la aplicacionde capaConsola en cmd temporal antes de crear la Presentacion
//se crea en MascotaFeliz.App osea aparece a la izq MascotaFeliz.App.Consola
//contiene un program.cs  hello World y vamos alla a instalar entityframework core design