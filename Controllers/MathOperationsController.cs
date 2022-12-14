using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMvc.Models;

namespace ExemploAspNetMvc.Controllers;


public class MathOperationsController : Controller
{
    private readonly ILogger<MathOperationsController> _logger;

    public MathOperationsController(ILogger<MathOperationsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Sum()
    {
        return View();
    }

    public IActionResult SumOperation([FromForm] double numberOne, [FromForm] double numberTwo) 
    {
        ViewBag.NumberOne = numberOne;
        ViewBag.NumberTwo = numberTwo;
        ViewBag.Result = numberOne + numberTwo;
        return View();
    }

    public IActionResult Sub()
    {
        return View();
    }

    public IActionResult SubOperation([FromForm] double numberOne, [FromForm] double numberTwo) 
    {
        ViewBag.NumberOne = numberOne;
        ViewBag.NumberTwo = numberTwo;
        ViewBag.Result = numberOne - numberTwo;
        return View();
    }
}