using System.ComponentModel.DataAnnotations;
using DataAccess.DataBase.Core.Domain.BaseDomain;

namespace DataAccess.Models;

public class HobbyCategory:  TEntity, ITEntity
{
    public string Name { get; set; }
    public DateTime? ModifiedDate { get; set; }
}