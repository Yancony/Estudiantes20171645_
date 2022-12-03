using System.ComponentModel.DataAnnotations;

namespace Estudiantes20171645.Data.Models;

public class Estudiante
{
public int estudianteID  {get; set;}
public string Nombres  {get; set;}= null!;
public string Apellidos  {get; set;}= null!;
public DateTime FechaNacimiento   {get; set;}
public string Matricula {get; set;}= null!;
public int CarreraId {get; set;}
public Carrera? Carrera { get; set; }
public string NombreCompleto => Nombres + " " + Apellidos;
}