﻿// <auto-generated />
using System;
using Avn.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Avn.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220920191859_ChangeOwnerAddress")]
    partial class ChangeOwnerAddress
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Avn.Domain.Entities.Attachment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Attachments", "File");
                });

            modelBuilder.Entity("Avn.Domain.Entities.Drop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AttachmentId")
                        .HasColumnType("int");

                    b.Property<byte>("CategoryType")
                        .HasColumnType("tinyint");

                    b.Property<Guid>("Code")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContentId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<byte>("DeliveryType")
                        .HasColumnType("tinyint");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<byte>("DropStatus")
                        .HasColumnType("tinyint");

                    b.Property<string>("DropUri")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVirtual")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("NetworkId")
                        .HasColumnType("int");

                    b.Property<Guid?>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReviewMessage")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Wages")
                        .HasColumnType("decimal(21,9)");

                    b.HasKey("Id");

                    b.HasIndex("AttachmentId");

                    b.HasIndex("NetworkId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Drops", "User");
                });

            modelBuilder.Entity("Avn.Domain.Entities.Network", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("GasFee")
                        .HasColumnType("decimal(21,9)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("SmartContractAddress")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint");

                    b.Property<decimal>("Wages")
                        .HasColumnType("decimal(21,9)");

                    b.HasKey("Id");

                    b.ToTable("Networks", "Base");
                });

            modelBuilder.Entity("Avn.Domain.Entities.NetworkInPricing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("NetworkId")
                        .HasColumnType("int");

                    b.Property<int>("PricingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NetworkId");

                    b.HasIndex("PricingId");

                    b.ToTable("NetworkInPricings");
                });

            modelBuilder.Entity("Avn.Domain.Entities.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Coin")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<byte>("Discount")
                        .HasColumnType("tinyint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethods", "Base");
                });

            modelBuilder.Entity("Avn.Domain.Entities.PaymentMethodInPricing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PaymentMethodId")
                        .HasColumnType("int");

                    b.Property<int>("PricingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("PricingId");

                    b.ToTable("PaymentMethodInPricings", "Base");
                });

            modelBuilder.Entity("Avn.Domain.Entities.Pricing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DiscountForYearlySubscription")
                        .HasColumnType("int");

                    b.Property<bool>("HasTransactionWages")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("PriorityTicketsSupport")
                        .HasColumnType("bit");

                    b.Property<bool>("PublicDocumentation")
                        .HasColumnType("bit");

                    b.Property<int>("RequestsPerDay")
                        .HasColumnType("int");

                    b.Property<int>("RequestsPerSecond")
                        .HasColumnType("int");

                    b.Property<bool>("TicketsSupport")
                        .HasColumnType("bit");

                    b.Property<int>("TokenPerDay")
                        .HasColumnType("int");

                    b.Property<int>("UsdtAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pricings", "Base");
                });

            modelBuilder.Entity("Avn.Domain.Entities.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("SourceIp")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Website")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Projects", "User");
                });

            modelBuilder.Entity("Avn.Domain.Entities.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<int>("PricingId")
                        .HasColumnType("int");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.Property<int>("TransactionId")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PricingId");

                    b.HasIndex("TransactionId");

                    b.HasIndex("UserId");

                    b.ToTable("Subscriptions", "User");
                });

            modelBuilder.Entity("Avn.Domain.Entities.Token", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ContractTokenId")
                        .HasColumnType("int");

                    b.Property<int>("DropId")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsBurned")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMinted")
                        .HasColumnType("bit");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("OwnerWalletAddress")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("UniqueCode")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("DropId");

                    b.ToTable("Tokens", "User");
                });

            modelBuilder.Entity("Avn.Domain.Entities.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("ConfirmDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("CryptoAmount")
                        .HasColumnType("decimal(21,9)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DiscountUsdtAmount")
                        .HasColumnType("decimal(21,9)");

                    b.Property<int>("PaymentMethodId")
                        .HasColumnType("int");

                    b.Property<byte>("Status")
                        .HasColumnType("tinyint");

                    b.Property<decimal>("TotalEndFee")
                        .HasColumnType("decimal(21,9)");

                    b.Property<string>("TxId")
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)");

                    b.Property<int>("UsdtAmount")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WalletAddress")
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("UserId");

                    b.ToTable("Transactions", "Payment");
                });

            modelBuilder.Entity("Avn.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)");

                    b.Property<bool>("EmailIsApproved")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("OrganizationName")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint");

                    b.Property<string>("WalletAddress")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users", "Auth");
                });

            modelBuilder.Entity("Avn.Domain.Entities.UserJwtToken", b =>
                {
                    b.Property<int>("UserJwtTokenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserJwtTokenId"), 1L, 1);

                    b.Property<DateTimeOffset>("AccessTokenExpiresTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("AccessTokenHash")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTimeOffset>("RefreshTokenExpiresTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("RefreshTokenHash")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserJwtTokenId");

                    b.HasIndex("UserId");

                    b.ToTable("UserJwtTokens", "Auth");
                });

            modelBuilder.Entity("Avn.Domain.Entities.VerificationCode", b =>
                {
                    b.Property<int>("VerificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VerificationId"), 1L, 1);

                    b.Property<DateTime>("ExpirationTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertDateMi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint");

                    b.Property<string>("UniqueCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("VerificationId");

                    b.HasIndex("UserId");

                    b.ToTable("VerificationCodes", "Auth");
                });

            modelBuilder.Entity("Avn.Domain.Entities.Drop", b =>
                {
                    b.HasOne("Avn.Domain.Entities.Attachment", "Attachment")
                        .WithMany("Drops")
                        .HasForeignKey("AttachmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avn.Domain.Entities.Network", "Network")
                        .WithMany("Drops")
                        .HasForeignKey("NetworkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avn.Domain.Entities.Project", "Project")
                        .WithMany("Drops")
                        .HasForeignKey("ProjectId");

                    b.HasOne("Avn.Domain.Entities.User", "User")
                        .WithMany("Drops")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attachment");

                    b.Navigation("Network");

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Avn.Domain.Entities.NetworkInPricing", b =>
                {
                    b.HasOne("Avn.Domain.Entities.Network", "Network")
                        .WithMany("NetworkInPricings")
                        .HasForeignKey("NetworkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avn.Domain.Entities.Pricing", "Pricing")
                        .WithMany("NetworkInPricings")
                        .HasForeignKey("PricingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Network");

                    b.Navigation("Pricing");
                });

            modelBuilder.Entity("Avn.Domain.Entities.PaymentMethodInPricing", b =>
                {
                    b.HasOne("Avn.Domain.Entities.PaymentMethod", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avn.Domain.Entities.Pricing", "Pricing")
                        .WithMany()
                        .HasForeignKey("PricingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentMethod");

                    b.Navigation("Pricing");
                });

            modelBuilder.Entity("Avn.Domain.Entities.Project", b =>
                {
                    b.HasOne("Avn.Domain.Entities.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Avn.Domain.Entities.Subscription", b =>
                {
                    b.HasOne("Avn.Domain.Entities.Pricing", "Pricing")
                        .WithMany()
                        .HasForeignKey("PricingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avn.Domain.Entities.Transaction", "Transaction")
                        .WithMany()
                        .HasForeignKey("TransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avn.Domain.Entities.User", "User")
                        .WithMany("Subscriptions")
                        .HasForeignKey("UserId");

                    b.Navigation("Pricing");

                    b.Navigation("Transaction");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Avn.Domain.Entities.Token", b =>
                {
                    b.HasOne("Avn.Domain.Entities.Drop", "Drop")
                        .WithMany("Tokens")
                        .HasForeignKey("DropId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drop");
                });

            modelBuilder.Entity("Avn.Domain.Entities.Transaction", b =>
                {
                    b.HasOne("Avn.Domain.Entities.PaymentMethod", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avn.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentMethod");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Avn.Domain.Entities.UserJwtToken", b =>
                {
                    b.HasOne("Avn.Domain.Entities.User", "User")
                        .WithMany("UserJwtTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Avn.Domain.Entities.VerificationCode", b =>
                {
                    b.HasOne("Avn.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Avn.Domain.Entities.Attachment", b =>
                {
                    b.Navigation("Drops");
                });

            modelBuilder.Entity("Avn.Domain.Entities.Drop", b =>
                {
                    b.Navigation("Tokens");
                });

            modelBuilder.Entity("Avn.Domain.Entities.Network", b =>
                {
                    b.Navigation("Drops");

                    b.Navigation("NetworkInPricings");
                });

            modelBuilder.Entity("Avn.Domain.Entities.Pricing", b =>
                {
                    b.Navigation("NetworkInPricings");
                });

            modelBuilder.Entity("Avn.Domain.Entities.Project", b =>
                {
                    b.Navigation("Drops");
                });

            modelBuilder.Entity("Avn.Domain.Entities.User", b =>
                {
                    b.Navigation("Drops");

                    b.Navigation("Projects");

                    b.Navigation("Subscriptions");

                    b.Navigation("UserJwtTokens");
                });
#pragma warning restore 612, 618
        }
    }
}
