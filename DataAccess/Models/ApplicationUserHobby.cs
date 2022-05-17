namespace DataAccess.Models;

public class ApplicationUserHobby: TEntity, ITEntity
{
    public DateTime Date { get; set; }

    public Guid ApplicationUserGuid { get; set; }
    public ApplicationUser ApplicationUser { get; set; }

    public Guid HobbyGuid { get; set; }
    public Hobby Hobby { get; set; }
}