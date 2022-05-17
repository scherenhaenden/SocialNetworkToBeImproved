using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models;

public class Post:  TEntity, ITEntity
{
    public Guid AuthorGuid { get; set; }
        
    public ApplicationUser Author { get; set; }
    public string Longitude { get; set; }
    public string Latitude { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime ModifiedDate { get; set; } = DateTime.Now;
    public Guid HobbyGuid { get; set; }
        
    public Hobby Hobby { get; set; }
    public string Text { get; set; }
      
}