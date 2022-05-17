using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models;

public class Hobby:  TEntity, ITEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int? TagCount { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public virtual Guid HobbyCategoryGuid { get; set; }
        
    public virtual HobbyCategory HobbyCategory { get; set; }
    //public ICollection<ApplicationUser> ApplicationUsers { get; set; }
    public List<ApplicationUserHobby> UserHobbies { get; set; }
}