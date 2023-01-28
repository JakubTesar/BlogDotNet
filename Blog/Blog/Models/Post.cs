using System.ComponentModel.DataAnnotations;

namespace Blog.Models;

public class Post
{
    [Required] public string Name { get; set; }
    [Required] public string Description { get; set; }
    public string DescriptionShort { get; set; }
    public DateTime DateTime { get; set; } = DateTime.Now;
    public int Id { get; set; }

    public Post(string name, string description)
    {
        Name = name;
        Description = description;
        if (description.Length > 100)
        {
            DescriptionShort = description.Substring(0, 100) + "...";
        }
        else
        {
            DescriptionShort = Description;
        }
    }
}