using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models;

public class Skill:  TEntity, ITEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
}