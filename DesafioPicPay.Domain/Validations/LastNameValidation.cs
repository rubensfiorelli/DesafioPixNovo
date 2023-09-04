using DesafioPicPay.Domain.Notifications;

namespace DesafioPicPay.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> LastNameIsOk(string lastName, string message, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}
