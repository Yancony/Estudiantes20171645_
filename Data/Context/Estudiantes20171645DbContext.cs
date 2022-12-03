using Estudiantes20171645.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace Estudiantes20171645.Data.Context;

public class Estudiantes20171645DbContext:DbContext,IEstudiantes20171645DbContext
{
    public Estudiantes20171645DbContext(DbContextOptions options):base(options)
    {

    }
  public virtual DbSet<Estudiante> Estudiantes {get; set;} = null!;

    public virtual DbSet<Carrera> Carrera {get; set;} = null!;
   
    public override int SaveChanges()
    {
        return base.SaveChanges();
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
}
public interface IEstudiantes20171645DbContext
{
    public DbSet<Estudiante> Estudiantes {get; set;}

    public  DbSet<Carrera> Carrera {get; set;}

    public int SaveChanges();

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
