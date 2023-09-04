using DesafioPicPay.Domain.Notifications;
using DesafioPicPay.Domain.Validations.Interfaces;

namespace DesafioPicPay.Domain.Validations
{
    public partial class ContractValidations<T> where T : IContract
    {
        private readonly List<Notification>? _notifications;

        public ContractValidations()
        {
        }

        public ContractValidations(List<Notification>? notifications)
        {
            _notifications = notifications;
        }

        public IReadOnlyCollection<Notification>? Notifications => _notifications;

        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);
        }

        public bool IsValid()
        {
            return _notifications.Count
                == 0;
        }
    }
}
