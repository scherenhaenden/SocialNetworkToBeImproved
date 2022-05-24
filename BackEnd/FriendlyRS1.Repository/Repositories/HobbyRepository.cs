using DataLayer.EntityModels;
using FriendlyRS1.Repository.RepostorySetup;
using System;
using System.Collections.Generic;
using System.Text;
using FriendlyRS1.Repository.RepositorySetup;

namespace FriendlyRS1.Repository.Repositories
{
    public class HobbyRepository : Repository<Hobby>
    {
        public HobbyRepository(ApplicationDbContext context):base(context)
        {
        }
        
        //some queries that are characteristic for only this EntityModel
        
        //...
    }
}
