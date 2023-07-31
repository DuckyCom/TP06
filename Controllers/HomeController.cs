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
        ViewBag.ListarCandidatos = BD.ListarCandidatos(idPartido);
        ViewBag.Partido = BD.VerInfoPartido(idPartido);
        return View("VerDetallePartido");
    }
    public IActionResult VerDetalleCandidato(int idCandidato)
    {
        ViewBag.Candidato = BD.VerInfoCandidato(idCandidato);
        return View("VerDetalleCandidato");
    }
    public IActionResult GuardarCandidato(Candidato can)
    {
        BD.AgregarCandidato(can);
        return RedirectToAction("VerDetallePartido", new {IdPartido = can.IdPartido});
    }
    public IActionResult AgregarCandidato(int idPartido)
    {
        ViewBag.IdPartido = idPartido;
        return View();
    }
    public IActionResult EliminarCandidato(int IdCandidato, int idPartido)
    {
        int registrosEliminados = BD.EliminarCandidato(IdCandidato);
        ViewBag.ListarCandidatos = BD.ListarCandidatos(idPartido);
        ViewBag.Partido = BD.VerInfoPartido(idPartido);
        return View("VerDetallePartido");
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
