using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

public class Create : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Post post)
    {
        
        return View("Index", post);
    }
}