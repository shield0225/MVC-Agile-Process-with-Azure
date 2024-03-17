using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    //public string Index()
    //{
    //    return "This is my default action...";
    //}

    public IActionResult Index()
    {
        return View();
    }

    // 
    // GET: /HelloWorld/Welcome/ 
    // /HelloWorld/Welcome?name=Rick&numtimes=4
    // Requires using System.Text.Encodings.Web;
    //public string Welcome(string name, int numTimes = 1)
    public string Welcome(string name, int ID = 1)
    {
        //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
}