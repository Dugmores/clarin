using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using clari.Models;

namespace clari.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
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
    //action for the rsvp form
    [HttpGet]
    public ViewResult RSVPForm(){
        return View();
    }
    
    //post the rsvp form
    [HttpPost]
    public ViewResult RSVPForm(GuestResponse response)
    {
        Repository.AddReponse(response);
        return View("Thanks", response);
    }
}
