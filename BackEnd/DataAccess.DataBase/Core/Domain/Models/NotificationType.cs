using System.ComponentModel.DataAnnotations;
using DataAccess.DataBase.Core.Domain.BaseDomain;

namespace DataAccess.Models;

public class NotificationType: TEntity, ITEntity
{
    public string NotificationDescription { get; set; }
    public string NotificationMessage { get; set; }
}