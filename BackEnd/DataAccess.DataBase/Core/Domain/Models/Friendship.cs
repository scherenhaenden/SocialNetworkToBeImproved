using System.ComponentModel.DataAnnotations;
using DataAccess.DataBase.Core.Domain.BaseDomain;

namespace DataAccess.Models;

public class Friendship:  TEntity, ITEntity
{
    public Guid User1Gui { get; set; }
        
    public ApplicationUser User1 { get; set; }
    public Guid User2Id { get; set; }
        
    public ApplicationUser User2 { get; set; }
    public Guid ActionUserGuid { get; set; }
        
    public ApplicationUser ActionUser { get; set; }
    public Guid StatusGuid { get; set; }
        
    public FriendshipStatus Status { get; set; }
}