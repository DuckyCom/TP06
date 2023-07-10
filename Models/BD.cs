namespace TP06.Models;
using Microsoft.Extensions.Configuration;   
using System.Data.SqlClient;
using Dapper;
public static class BD
{
public static string _connectionString = @"Server=localhost;Database=Elecciones2023;Trusted_Connection=True;";
public static void AgregarCandidato(Candidato can)
{
    string SQL = "INSERT INTO Candidato(IdCandidato,IdPartido,Apellido,Nombre,FechaNacimiento,Foto,Postulacion) VALUES (@pIdCandidato,@pIdPartido,@pApellido,@pNombre,@pFechaNacimiento,@pFoto,@pPostulacion)";
    using(SqlConnection db = new SqlConnection(_connectionString))
    {
        db.Execute(SQL, new {pIdCandidato = can.IdCandidato, pIdPartido = can.IdPartido, pApellido = can.Apellido, pNombre = can.Nombre, pFechaNacimiento = can.FechaNacimiento, pFoto = can.Foto, pPostulacion = can.Postulacion});
    }
}

public static int EliminarCandidato(int pidCandidato)
{
    int registrosEliminados = 0;
    string SQL = "DELETE * FROM Candidato WHERE IdCandidato = @pidCandidato";
    using(SqlConnection db = new SqlConnection(_connectionString))
    {
        registrosEliminados = db.Execute(SQL, new {IdCandidato = pidCandidato});
    }
    return registrosEliminados;
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

public static List<Partido> ListarPartidos()
{
    List<Partido> _ListaPartidos = new List<Partido>();
    using(SqlConnection db = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM Partido";
        _ListaPartidos = db.Query<Partido>(sql).ToList(); 
    }
    return _ListaPartidos;
}

public static List<Candidato> ListarCandidatos(int pidPartido)
{
    List<Candidato> _ListaCandidatos = new List<Candidato>();
    using(SqlConnection db = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM Candidato WHERE IdPartido = @pidPartido";
        _ListaCandidatos = db.Query<Candidato>(sql, new {IdPartido = pidPartido}).ToList(); 
    }
    return _ListaCandidatos;
}
}
