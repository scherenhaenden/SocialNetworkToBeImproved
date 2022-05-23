using DataAccess.DataBase.Core.Repositories;
using DataAccess.Models;

namespace DataAccess.DataBase.Core.UnitiesOfWork;

public interface IUnitOfWorkV2: IDisposable
{
    IRepository<Gender> Gender { get; }

    public IRepository<ApplicationUser> Users { get;  }
    
    public IRepository<Hobby> Hobby { get;  }
    public IRepository<HobbyCategory> HobbyCategory { get;  }
    
    public IRepository<City> City { get;  }
    public IRepository<Country> Country { get;  }
    
    public IRepository<FriendshipStatus> FriendshipStatus { get;  }
    public IRepository<Friendship> Friendship { get;  }
    public IRepository<ApplicationUserHobby> ApplicationUserHobbies { get;  }
    public IRepository<Post> Post { get;  }
    public IRepository<NotificationType> NotificationType { get;  }
    public IRepository<BellNotification> BellNotification { get;  }
    public IRepository<Skill> Skill { get;  }
    
    public IRepository<Roles> Roles { get;  }
    
    int Complete();
}