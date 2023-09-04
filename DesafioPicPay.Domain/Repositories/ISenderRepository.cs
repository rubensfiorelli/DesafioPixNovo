using DesafioPicPay.Domain.Entities;

namespace DesafioPicPay.Domain.Repositories
{
    public interface ISenderRepository
    {
        Task<Sender> GetSenderByDocument(string document);
        Task<Sender> GetSenderById(Guid senderId);

    }
}
