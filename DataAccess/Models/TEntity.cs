using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models;

public interface ITEntity
{
    public Guid Guid { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime Created { get; set; }
    
}


public class TEntity: ITEntity
{
    public Guid Guid { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime Created { get; set; }
}