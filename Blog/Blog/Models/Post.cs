namespace Blog.Models;

public class Post
{
    public string Name { get; set;}
    public string Description{ get; set;}
    public string DescriptionShort{ get; set;}
    public DateTime DateTime { get; set; } = DateTime.Now;

    public Post(string name, string description, string descriptionShort)
    {
        Name = name;
        Description = description;
        DescriptionShort = descriptionShort;
    }
}