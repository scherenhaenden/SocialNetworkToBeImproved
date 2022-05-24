using System.ComponentModel.DataAnnotations;
using DataAccess.DataBase.Core.Domain.BaseDomain;

namespace DataAccess.Models;

public class BellNotification:  TEntity, ITEntity
{
    // this is a bit different
    public Guid? ActorGuid { get; set; }
    public ApplicationUser Actor { get; set; }
    public Guid NotifierGuid { get; set; }
        
    public ApplicationUser Notifier { get; set; }
    public Guid NotificationTypeGuid { get; set; }
        
    public NotificationType NotificationType { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public bool IsRead { get; set; }
}