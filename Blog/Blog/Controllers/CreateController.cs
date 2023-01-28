using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

public class Create : Controller
{
    // GET
    public IActionResult Index()
    {
       // Post model = new Post();
        return View();
    }
    [HttpPost]
    public IActionResult Index(Post post)
    {
        
        return View("Index", post);
    }
}