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
    public ActionResult FinalMadLib (MadLibTemplate model)
    {
      return View("FinalMadLib", model);
    }
  }
}