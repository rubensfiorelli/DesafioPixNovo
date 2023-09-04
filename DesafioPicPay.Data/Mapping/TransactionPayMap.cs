using DesafioPicPay.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioPicPay.Data.Mapping
{
    public class TransactionPayMap : IEntityTypeConfiguration<TransactionPay>
    {
        public void Configure(EntityTypeBuilder<TransactionPay> builder)
        {
            builder
                .Property(p => p.Amount)
                .HasPrecision(10, 2);

            builder
                .Property(o => o.SenderId)
                .ValueGeneratedNever();

            builder
               .Property(o => o.ReceiverId)
               .ValueGeneratedNever();

            builder
                .HasKey(tp => new { tp.SenderId, tp.ReceiverId });

        }
    }
}
