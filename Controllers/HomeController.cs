using Microsoft.AspNetCore.Mvc;
using TP06.Models;
namespace TP06.Controllers;
using System.Data.SqlClient;
using Dapper;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaPartidos = BD.ListarPartidos();
        return View();
    }
    public IActionResult VerDetallePartido(int idPartido)
    {
        ViewBag.Partido = BD.VerInfoPartido(idPartido);
        ViewBag.ListarCandidatos = BD.ListarCandidatos(idPartido);
        return View("DetallePartido");
    }
    public IActionResult VerDetalleCandidato(int idCandidato)
    {
        ViewBag.Candidato = BD.VerInfoCandidato(idCandidato);
        return View("DetalleCandidato");
    }
    [HttpPost]
    public IActionResult GuardarCandidato(Candidato can)
    {
        BD.AgregarCandidato(can);
        ViewBag.Partido = BD.VerInfoPartido(can.IdPartido);
        ViewBag.ListarCandidatos = BD.ListarCandidatos(can.IdPartido);
        return View("DetallePartido");
    }
    public IActionResult GuardarCandidato(int idCandidato, int IdPartido)
    {
        BD.EliminarCandidato(idCandidato);
        ViewBag.Partido = BD.VerInfoPartido(IdPartido);
        ViewBag.ListarCandidatos = BD.ListarCandidatos(IdPartido);
        return View("DetallePartido");
    }
    public IActionResult Elecciones()
    {
        return View();
    }
    public IActionResult Creditos()
    {
        return View();
    }
}
