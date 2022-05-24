using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DataBase.Core.Configuration.EntityFramework;

public class EFContext: DbContext
{
    private readonly string connectionString;

    public EFContext(DbContextOptions<EFContext> options)
        : base(options)
    { }

    public EFContext(string connectionString)
    {
        this.connectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        try
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                return;
            }
                
            
            /*optionsBuilder.UseMySql(connectionString,
                new MariaDbServerVersion(new Version(10, 5, 8)) 
            );*/
        }
        catch (TypeLoadException exception)
        {
            var gh = exception.Message;

        }
    }
    
    public DbSet<Gender> Gender { get; set; }
    
    public DbSet<ApplicationUser> Users { get; set; }
    
    public DbSet<Hobby> Hobby { get; set; }
    public DbSet<HobbyCategory> HobbyCategory { get; set; }
    
    public DbSet<City> City { get; set; }
    public DbSet<Country> Country { get; set; }
    
    public DbSet<FriendshipStatus> FriendshipStatus { get; set; }
    public DbSet<Friendship> Friendship { get; set; }
    public DbSet<ApplicationUserHobby> ApplicationUserHobbies { get; set; }
    public DbSet<Post> Post { get; set; }
    public DbSet<NotificationType> NotificationType { get; set; }
    public DbSet<BellNotification> BellNotification { get; set; }
    public DbSet<Skill> Skill { get; set; }
    
    public DbSet<Roles> Roles { get; set; }

}