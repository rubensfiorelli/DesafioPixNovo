using DesafioPicPay.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioPicPay.Data.Mapping
{
    public class ReceiverMap : IEntityTypeConfiguration<Receiver>
    {
        public void Configure(EntityTypeBuilder<Receiver> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(f => f.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(l => l.LastName)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(e => e.Email)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .HasIndex(x => x.Email)
                .IsUnique();

            builder
                .OwnsOne(d => d.Document);

            builder
                .Property(p => p.CreateAt)
                .HasDefaultValueSql("GETDATE()")
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

        }
    }
}
