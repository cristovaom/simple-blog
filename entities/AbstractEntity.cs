using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.entities;

public class AbstractEntity
{
    [Key]
    public int Id { get; set; }
    [Column]
    public DateTime CreatedAt { get; set; }
    
}