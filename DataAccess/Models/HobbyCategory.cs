using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models;

public class HobbyCategory:  TEntity, ITEntity
{
    public string Name { get; set; }
    public DateTime? ModifiedDate { get; set; }
}