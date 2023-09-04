using DesafioPicPay.Domain.Notifications;

namespace DesafioPicPay.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> TalkTitleIsOk(string talkTitle, string message, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(talkTitle))

                AddNotification(new Notification(message, propertyName));

            return this;
        }

    }
}
