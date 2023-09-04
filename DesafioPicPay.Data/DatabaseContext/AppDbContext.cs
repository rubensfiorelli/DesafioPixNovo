using DesafioPicPay.Domain.Entities;
using DesafioPicPay.Domain.Notifications;
using Microsoft.EntityFrameworkCore;

namespace DesafioPicPay.Data.DatabaseContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }

        public DbSet<Receiver> Receivers { get; set; }
        public DbSet<Sender> Senders { get; set; }
        public DbSet<TransactionPay> Transactions { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = true;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);


        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .Entity<Notification>()
                .HasKey(e => e.Id);

            builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
