using DesafioPicPay.Domain.Notifications.Interfaces;
using DesafioPicPay.Domain.Primitives;

namespace DesafioPicPay.Domain.Notifications
{
    public class Notification : BaseEntity, INotification
    {
        public Notification(string message, string propertyName)
        {
            Message = message;
            PropertyName = propertyName;
        }

        public string Message { get; private set; }
        public string PropertyName { get; private set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
