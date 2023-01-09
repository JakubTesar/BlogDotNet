using System.Diagnostics;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
namespace Blog.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        List<Post> posts = new List<Post>();
        string[] lines =System.IO.File.ReadAllLines(@"presidents.csv");
        for (int i = 1; i < lines.Length; i++) {
            string[] epicLine = lines[i].Split(",");
            Post post = new Post(epicLine[0],epicLine[1], epicLine[1].Substring(0,100));
            posts.Add(post);
        }
        return View(posts);
    }
    
}