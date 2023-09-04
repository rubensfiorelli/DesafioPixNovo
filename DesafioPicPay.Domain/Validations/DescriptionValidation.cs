using DesafioPicPay.Domain.Notifications;

namespace DesafioPicPay.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> DescriptionIsOk(string description, string message, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(description))

                AddNotification(new Notification(message, propertyName));

            return this;
        }

    }
}
