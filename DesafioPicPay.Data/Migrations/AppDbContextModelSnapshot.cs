﻿// <auto-generated />
using System;
using DesafioPicPay.Data.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DesafioPicPay.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DesafioPicPay.Domain.Entities.Receiver", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTimeOffset>("UpdateAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Receivers");
                });

            modelBuilder.Entity("DesafioPicPay.Domain.Entities.Sender", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTimeOffset>("UpdateAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Senders");
                });

            modelBuilder.Entity("DesafioPicPay.Domain.Entities.TransactionPay", b =>
                {
                    b.Property<Guid>("SenderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ReceiverId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTimeOffset>("CreateAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DateTransfer")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("UpdateAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("SenderId", "ReceiverId");

                    b.HasIndex("ReceiverId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("DesafioPicPay.Domain.Notifications.Notification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreateAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdateAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Notification");
                });

            modelBuilder.Entity("DesafioPicPay.Domain.Entities.Receiver", b =>
                {
                    b.OwnsOne("DesafioPicPay.Domain.ValueObjects.Document", "Document", b1 =>
                        {
                            b1.Property<Guid>("ReceiverId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("CPFouCNPJ")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ReceiverId");

                            b1.ToTable("Receivers");

                            b1.WithOwner()
                                .HasForeignKey("ReceiverId");
                        });

                    b.Navigation("Document")
                        .IsRequired();
                });

            modelBuilder.Entity("DesafioPicPay.Domain.Entities.Sender", b =>
                {
                    b.OwnsOne("DesafioPicPay.Domain.ValueObjects.Document", "Document", b1 =>
                        {
                            b1.Property<Guid>("SenderId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("CPFouCNPJ")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("SenderId");

                            b1.ToTable("Senders");

                            b1.WithOwner()
                                .HasForeignKey("SenderId");
                        });

                    b.Navigation("Document");
                });

            modelBuilder.Entity("DesafioPicPay.Domain.Entities.TransactionPay", b =>
                {
                    b.HasOne("DesafioPicPay.Domain.Entities.Receiver", "Receiver")
                        .WithMany("Transactions")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DesafioPicPay.Domain.Entities.Sender", "Sender")
                        .WithMany("Transactions")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("DesafioPicPay.Domain.Entities.Receiver", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("DesafioPicPay.Domain.Entities.Sender", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}