using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models;

public class NotificationType: TEntity, ITEntity
{
    public string NotificationDescription { get; set; }
    public string NotificationMessage { get; set; }
}