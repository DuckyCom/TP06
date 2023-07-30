namespace TP06.Models;
using Microsoft.Extensions.Configuration;   
using System.Data.SqlClient;
using Dapper;
public static class BD
{
public static string _connectionString = @"Server=localhost;Database=Elecciones2023;Trusted_Connection=True;";
public static void AgregarCandidato(Candidato can)
{
    string SQL = "INSERT INTO Candidato(IdPartido,Apellido,Nombre,FechaNacimiento,Foto,Postulacion) VALUES (@pIdPartido,@pApellido,@pNombre,@pFechaNacimiento,@pFoto,@pPostulacion)";
    using(SqlConnection db = new SqlConnection(_connectionString))
    {
        db.Execute(SQL, new {pIdPartido = can.IdPartido, pApellido = can.Apellido, pNombre = can.Nombre, pFechaNacimiento = can.FechaNacimiento, pFoto = can.Foto, pPostulacion = can.Postulacion});
    }
}

public static int EliminarCandidato(int IdCandidato)
{
    int registrosEliminados = 0;
    string SQL = "DELETE FROM Candidato WHERE IdCandidato = @pIdCandidato";
    using(SqlConnection db = new SqlConnection(_connectionString))
    {
        registrosEliminados = db.Execute(SQL, new {pIdCandidato = IdCandidato});
    }
    return registrosEliminados;
}
//¿devuelve un "objeto partido"?
public static Partido VerInfoPartido(int IdPartido)
{
    Partido miPartido = null;
    using(SqlConnection db = new SqlConnection(_connectionString))
    {
        string sql = "SELECT [IdPartido],[Nombre],[Logo],[SitioWeb],[FechaFundacion],[CantidadDiputados],[CantidadSenadores] FROM [dbo].[Partido] WHERE IdPartido = @pIdPartido";
        miPartido = db.QueryFirstOrDefault<Partido>(sql, new {pIdPartido = IdPartido});
    }
    return miPartido;
}
//lo mismo que arriba
public static Candidato VerInfoCandidato(int IdCandidato)
{
    Candidato miCandidato = null;
    using(SqlConnection db = new SqlConnection(_connectionString))
    {
        string sql = "SELECT [IdCandidato] ,[IdPartido] ,[Apellido],[Nombre],[FechaNacimiento],[Foto],[Postulacion] FROM [dbo].[Candidato] WHERE IdCandidato = @pIdCandidato";
        miCandidato = db.QueryFirstOrDefault<Candidato>(sql, new {pIdCandidato = IdCandidato}); 
    }
    return miCandidato;
}

public static List<Partido> ListarPartidos()
{
    List<Partido> _ListaPartidos = new List<Partido>();
    using(SqlConnection db = new SqlConnection(_connectionString))
    {
        string sql = "SELECT [IdPartido],[Nombre],[Logo],[SitioWeb],[FechaFundacion],[CantidadDiputados],[CantidadSenadores] FROM [dbo].[Partido]";
        _ListaPartidos = db.Query<Partido>(sql).ToList(); 
    }
    return _ListaPartidos;
}

public static List<Candidato> ListarCandidatos(int IdPartido)
{
    List<Candidato> _ListaCandidatos = new List<Candidato>();
    using(SqlConnection db = new SqlConnection(_connectionString))
    {
        string sql = "SELECT [IdCandidato] ,[IdPartido] ,[Apellido],[Nombre],[FechaNacimiento],[Foto],[Postulacion] FROM [dbo].[Candidato] WHERE IdPartido = @pIdPartido";
        _ListaCandidatos = db.Query<Candidato>(sql, new {pIdPartido = IdPartido}).ToList(); 
    }
    return _ListaCandidatos;
}
}
