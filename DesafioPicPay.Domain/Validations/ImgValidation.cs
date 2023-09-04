using DesafioPicPay.Domain.Notifications;

namespace DesafioPicPay.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> ImgIsOk(string img, string message, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(img))

                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}
