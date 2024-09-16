using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.entities;

[Table("tb_posts")]
public class Post : AbstractEntity
{
    [Column("tittle")]
    public string Tittle { get; set; }
    [Column("description")]
    public string Description { get; set; }

    public List<Comment> Comments = new List<Comment>();
    
    public Post(){}
    public Post(string tittle, string description)
    {
        Tittle = tittle;
        Description = description;
    }
}