using DataLayer.EntityModels;
using FriendlyRS1.Repository.RepostorySetup;
using System;
using System.Collections.Generic;
using System.Text;
using FriendlyRS1.Repository.RepositorySetup;

namespace FriendlyRS1.Repository.Repositories
{
    public class FriendshipStatusRepository: Repository<FriendshipStatus>
    {
        public FriendshipStatusRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
