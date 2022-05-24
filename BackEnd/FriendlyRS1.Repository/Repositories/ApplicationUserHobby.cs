using DataLayer.EntityModels;
using FriendlyRS1.Repository;
using FriendlyRS1.Repository.RepositorySetup;

namespace DataLayer.Repositories
{
    public class ApplicationUserHobbyRepository:Repository<ApplicationUserHobby>
    {
        public ApplicationUserHobbyRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
