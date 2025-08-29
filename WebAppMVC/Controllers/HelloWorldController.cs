using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.Models;
// using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.DynamicViewData.ViewBag;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    //public string Welcome(string name, int ID = 1)
    //{
    //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    //}

    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
    public string Goodbye()
    {
        return "This is the Goodbye action method...";
    }

    public IActionResult Greeting()
    {
        ViewData["Greeting"] = "Keith";
        ViewData["MyMovie"]  = new Movie()
        {
            Id=100,
            Title="Greeting from Hello",
            Genre="APP",
            Rating="R"
        };

        // ViewBag."Greeting" = "Keith";
        // ViewBag."MyMovie"  = new Movie()
        // {
        //     Id=100,
        //     Title="Greeting from Hello",
        //     Genre="APP",
        //     Rating="R"
        // };
    
        return View();
    }
    }