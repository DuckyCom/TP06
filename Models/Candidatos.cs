namespace TP06.Models;
public class Candidato
{
    public int IdPartido {get; set;}
    public int IdCandidato {get; set;}
    public string Nombre {get; set;}
    public string Apellido {get; set;}
    public string Foto {get; set;}
    public string Postulacion {get; set;}
    public DateTime FechaNacimiento {get; set;}
}