using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using test2.Models;

namespace test2.Controllers;

public class HomeController : Controller
{
    
    private readonly ILogger<HomeController> _logger;
    


    public IActionResult Index()
    {
        return View();
    }

  

 
}