using DesafioPicPay.Domain.Notifications;

namespace DesafioPicPay.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> FirstNameIsOk(string firstName, string message, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}
