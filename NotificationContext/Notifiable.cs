using System.Collections.Generic;
using System.Linq;

namespace Projeto.NotificationContext
{
    public abstract class Notifiable
    {
        public Notifiable()
        {
            Notifications = new List<Notification>();
        }
        public List<Notification> Notifications { get; set; }

        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }
        public void AddRangeNotification(IEnumerable<Notification> notification)
        {
            Notifications.AddRange(notification);
        }
        public bool IsValid => Notifications.Any();
    }
}