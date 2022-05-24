using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.EntityModels
{
    public class NotificationType: Entity, IEntity
    {
        public string NotificationDescription { get; set; }
        public string NotificationMessage { get; set; }
    }
}
