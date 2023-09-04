using DesafioPicPay.Domain.Notifications;

namespace DesafioPicPay.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> VisitorIsOk(int visitor, string message, string propertyName)
        {
            if (visitor <= 0)
                AddNotification(new Notification(message, propertyName));


            return this;
        }
    }
}
