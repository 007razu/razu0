using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using test2.Models;

namespace test2.Areas.Admin.Controllers;
[Area("Admin")]

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

 
}