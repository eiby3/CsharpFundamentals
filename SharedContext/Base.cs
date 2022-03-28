using System;
using Projeto.NotificationContext;

namespace Projeto.SharedContext
{
    public class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}