using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.DataBase.Core.Domain.BaseDomain;

namespace DataAccess.Models;

[Table("UserHobbies")]
public class ApplicationUserHobby: TEntity, ITEntity
{
    public DateTime Date { get; set; }

    public Guid ApplicationUserGuid { get; set; }
    public ApplicationUser ApplicationUser { get; set; }

    public Guid HobbyGuid { get; set; }
    public Hobby Hobby { get; set; }
}