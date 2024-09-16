using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.entities;

[Table("tb_comments")]
public class Comment : AbstractEntity
{
    [Column("text")]
    public string Text { get; set; }
    [Column("post_id")]
    public int PostId { get; set; }
 
    public Comment(){}
    
    public Comment(string text, int postId)
    {
        Text = text;
        PostId = postId;
    }
}