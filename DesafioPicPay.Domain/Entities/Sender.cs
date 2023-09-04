using DesafioPicPay.Domain.Enum;
using DesafioPicPay.Domain.Primitives;
using DesafioPicPay.Domain.Validations.Interfaces;
using DesafioPicPay.Domain.ValueObjects;

namespace DesafioPicPay.Domain.Entities
{
    public sealed class Sender : BaseEntity, IContract
    {
        public Sender(string firstName,
                      string lastName,
                      string email,
                      decimal balance) : base()
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Balance = balance;
            UserType = UserType.Common;

            Transactions = new List<TransactionPay>();
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Document? Document { get; private set; }
        public string Email { get; private set; }
        public decimal Balance { get; private set; }
        public UserType UserType { get; private set; }

        public List<TransactionPay> Transactions { get; private set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
