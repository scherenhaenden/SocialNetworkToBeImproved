namespace DataAccess.Models;

public class ApplicationUser : TEntity, ITEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public DateTime DateModified { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateOfBirth { get; set; }
    public bool ActiveAccount { get; set; }
    public Guid GenderGuid { get; set; }

    public virtual Gender Gender { get; set; }
    public Guid? CityGuid { get; set; }

    public City City { get; set; }

    public byte[] ProfileImage { get; set; }

    //public ICollection<Hobby> Hobbies { get; set; }
    public string About { get; set; }
    public List<ApplicationUserHobby> UserHobbies { get; set; }
}