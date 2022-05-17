using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models;

public class FriendshipStatus:  TEntity, ITEntity
{
    public byte Status { get; set; }
}