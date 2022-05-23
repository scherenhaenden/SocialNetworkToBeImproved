using DataLayer.EntityModels;
using FriendlyRS1.Repository.RepostorySetup;
using System;
using System.Collections.Generic;
using System.Text;
using FriendlyRS1.Repository.RepositorySetup;

namespace FriendlyRS1.Repository.Repositories
{
    public class HobbyCategoryRepository:Repository<HobbyCategory> 
    {
        public HobbyCategoryRepository(ApplicationDbContext context):base(context)
        {
        }
    }
}
