using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult FinalMadLib ()
    {
      return View(new MadLibTemplate(
        "Gabe", 
        "Venice", 
        "phone", 
        "Monkey", 
        "knitting" 
      ));
    }
  }
}