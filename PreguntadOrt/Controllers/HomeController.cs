using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PreguntadOrt.Models;
using System.Linq;
using System.Data.SqlClient;

namespace PreguntadOrt.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        ViewBag.ranking = BD.ObtenerRanking();
        return View();
    }
    [HttpGet]public IActionResult ConfigurarJuego()
    {   
        Juego.InicializarJuego();
        ViewBag.dificultades= BD.ObtenerDificultades();
        ViewBag.categorias= BD.ObtenerCategorias();     
        return View();
    }
    public IActionResult Comenzar(string username, int dificultad, int categoria)
    {   
            Juego.CargarPartida(username, dificultad,categoria);                
            return RedirectToAction("Jugar");            
    }
    public IActionResult Jugar()
    {   
        Pregunta p= Juego.ObtenerProximaPregunta();
        ViewBag.username=Juego.Username;
        ViewBag.puntaje=Juego.PuntajeActual;
        ViewBag.pregactual = Juego.PreguntaActual;
        if(p is null){
            Ranking r = new Ranking();
            r.PuntajeFinal= Juego.PuntajeActual;
            r.NombreUser= Juego.Username;
            BD.AgregarJugador(r);
            return View("Fin");
        }
        else{
            ViewBag._Respuestas = Juego.ObtenerProximasRespuestas(p.IdPregunta);
            ViewBag.Pregunta = p;
            return View("Jugar");
        }
    }
    [HttpPost] public IActionResult VerificarRespuesta(int idPregunta, int idRespuesta)
    {
        ViewBag.Correcta = Juego.VerificarRespuesta(idPregunta, idRespuesta);
        return View("Respuesta");
    }
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
