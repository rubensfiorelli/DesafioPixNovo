using DesafioPicPay.Domain.Primitives;
using DesafioPicPay.Domain.Validations.Interfaces;

namespace DesafioPicPay.Domain.Entities
{
    public sealed class TransactionPay : AggregateRoot, IContract
    {
        public TransactionPay(decimal amount,
                              Guid senderId,
                              Guid receiverId) : base()
        {
            Amount = amount;
            SenderId = senderId;
            ReceiverId = receiverId;
            DateTransfer = DateTime.UtcNow;
        }

        public decimal Amount { get; private set; }
        public Guid SenderId { get; private set; }
        public Sender? Sender { get; private set; }
        public Guid ReceiverId { get; private set; }
        public Receiver? Receiver { get; private set; }
        public DateTimeOffset DateTransfer { get; private set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
