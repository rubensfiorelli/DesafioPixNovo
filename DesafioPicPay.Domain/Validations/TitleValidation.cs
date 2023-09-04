using DesafioPicPay.Domain.Notifications;

namespace DesafioPicPay.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> TitleIsOk(string title, string message, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(title))
                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}
