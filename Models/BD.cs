namespace TP06.Models;

public class Partido
{
    public int IdPartido {get; set;}
    public int CantidadDiputados {get; set;}
    public int CantidadSenadores {get; set;}
    public string Nombre {get; set;}
    public string Logo {get; set;}
    public string SitioWeb {get; set;}
    public DateTime FechaFundacion {get; set;}
}
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
public static class BD
{ //Crear todos los métodos privados que se requieran

static void AgregarCandidato(Candidato can)
{

}

static void EliminarCandidato(int idCandidato)
{

}
//¿devuelve un "objeto partido"?
static void VerInfoPartido(int idPartido)
{

}
//lo mismo que arriba
static void VerInfoCandidato(int idCandidato)
{

}

/* static List ListarPartidos()
{


} */

/* static List ListarCandidatos(int idPartido)
{

} */



}
