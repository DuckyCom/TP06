namespace TP06.Models;
using System.Data.SqlClient;
using Dapper;
public static class BD
{ //Crear todos los métodos privados que se requieran
private static string _connectionString = @"Server=localhost;Database=Elecciones2023.sql;Trusted_Connection=True;";

static void AgregarCandidato(Candidato can)
{

}

static void EliminarCandidato(int idCandidato)
{

}
//¿devuelve un "objeto partido"?
public static Partido VerInfoPartido(int pidPartido)
{
    Partido miPartido = null;
    using(SqlConnection db = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM Partido WHERE IdPartido = @pidPartido";
        miPartido = db.QueryFirstOrDefault<Partido>(sql, new {IdPartido = pidPartido}); 
    }
    return miPartido;
}
//lo mismo que arriba
public static Candidato VerInfoCandidato(int pidCandidato)
{
    Candidato miCandidato = null;
    using(SqlConnection db = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM Partido WHERE IdCandidato = @pidCandidato";
        miCandidato = db.QueryFirstOrDefault<Candidato>(sql, new {IdCandidato = pidCandidato}); 
    }
    return miCandidato;
}

/* static List ListarPartidos()
{


} */

/* static List ListarCandidatos(int idPartido)
{

} */



}
