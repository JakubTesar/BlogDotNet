using System.Diagnostics;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
namespace Blog.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        List<Post> posts = new List<Post>();
        string[] lines =System.IO.File.ReadAllLines("blog.csv");
        for (int i = 0; i < lines.Length; i++) {
            string[] epicLine = lines[i].Split(";");
            Post post = new Post(epicLine[0],epicLine[1]);
            posts.Add(post);
        }
        Post post1 = new Post("mrwof","POGE");
        posts.Add(post1);
        return View(posts);
    }
    
}