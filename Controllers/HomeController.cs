using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using series.Models;

namespace series.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

public IActionResult Index()
{
    ViewBag.listaSeries = BD.ObtenerSeries();
    return View();
}

public Series VerInfoSerieAjax(int IdSerie)
{
    return BD.GetSerie(IdSerie);
}
   
 public List<Actores> VerInfoActoresAjax(int IdSerie)
    {
        return BD.ObtenerActores(IdSerie);
    }

  public List<Temporadas> VerInfoTemporadasAjax(int IdSerie)
    {
        return BD.ObtenerTemporadas(IdSerie);
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    //cargar las serires de la base de datos en un viwbag
}



    

  