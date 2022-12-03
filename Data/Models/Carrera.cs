using System.ComponentModel.DataAnnotations;

namespace Estudiantes20171645.Data.Models;

public class Carrera
{
    public Carrera()
    {
        
    }
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    
}