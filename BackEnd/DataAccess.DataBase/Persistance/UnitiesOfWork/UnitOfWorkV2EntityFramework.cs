using DataAccess.DataBase.Core.Configuration.EntityFramework;
using DataAccess.DataBase.Core.Repositories;
using DataAccess.DataBase.Core.UnitiesOfWork;
using DataAccess.DataBase.Persistance.Repository.EntityFramework;
using DataAccess.Models;

namespace DataAccess.DataBase.Persistance.UnitiesOfWork;

public class UnitOfWorkV2EntityFramework: IUnitOfWorkV2
{
    private readonly EFContext _context;

    public UnitOfWorkV2EntityFramework(EFContext context)
    {
        _context = context;
        Gender = new RepositoryEntityFramework<Gender>(context);
        Roles = new RepositoryEntityFramework<Roles>(context);
    }
    private bool _disposed;
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
        _disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public IRepository<Gender> Gender { get; }
    public IRepository<ApplicationUser> Users { get; }
    public IRepository<Hobby> Hobby { get; }
    public IRepository<HobbyCategory> HobbyCategory { get; }
    public IRepository<City> City { get; }
    public IRepository<Country> Country { get; }
    public IRepository<FriendshipStatus> FriendshipStatus { get; }
    public IRepository<Friendship> Friendship { get; }
    public IRepository<ApplicationUserHobby> ApplicationUserHobbies { get; }
    public IRepository<Post> Post { get; }
    public IRepository<NotificationType> NotificationType { get; }
    public IRepository<BellNotification> BellNotification { get; }
    public IRepository<Skill> Skill { get; }
    public IRepository<Roles> Roles { get; }

    public int Complete()
    {
        return _context.SaveChanges();
    }
}