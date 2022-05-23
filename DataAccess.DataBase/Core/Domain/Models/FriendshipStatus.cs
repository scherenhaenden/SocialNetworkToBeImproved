using System.ComponentModel.DataAnnotations;
using DataAccess.DataBase.Core.Domain.BaseDomain;

namespace DataAccess.Models;

public class FriendshipStatus:  TEntity, ITEntity
{
    public byte Status { get; set; }
}