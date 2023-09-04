using DesafioPicPay.Domain.Notifications;
using System.Text.RegularExpressions;

namespace DesafioPicPay.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> EmailIsOk(string email, string message, string propertyName)
        {
            if (string.IsNullOrEmpty(email) || !MyRegex().IsMatch(email))
                AddNotification(new Notification(message, propertyName));

            return this;
        }

        [GeneratedRegex("^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$")]
        private static partial Regex MyRegex();
    }
}
