using DesafioPicPay.Domain.Notifications;

namespace DesafioPicPay.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> BioIsOk(string bio, string message, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(bio))

                AddNotification(new Notification(message, propertyName));

            return this;
        }

    }
}
