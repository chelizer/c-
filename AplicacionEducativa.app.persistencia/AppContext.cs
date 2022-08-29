using Microsoft.EntityFrameworkCore;
namespace AplicacionEducativa.app.dominio.Entidades

{
    public class dbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=LAPTOP-7ENSJ5DM;Initial Catalog=Prueba2;Integrated Security=True");

        }
              

               public DbSet<Alumno> alumno { get; set; }
               public DbSet<Materia> materia { get; set; }




    }
}

