using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using clari.Models;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

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
        if (ModelSate.IsValid)
        {
          Repository.AddReponse(response);
          return View("Thanks", response);
        }
        else
        {
            //there is a validation error
            return View();
        }
    }


    //list all responses action method
    public ViewResult ListReponses()
    {
        return View(Repository.Responses.Where(r => r.WillAttend == true));
    }
}
