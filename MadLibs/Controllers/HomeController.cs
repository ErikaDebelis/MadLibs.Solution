using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form ()
    {
      return View();
    }
    [Route("/result")]
    public ActionResult Hangover (MadLibTemplate model)
    {
      return View("Hangover", model);
    }
  }
}