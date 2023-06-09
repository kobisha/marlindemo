﻿// <auto-generated />
using System;
using Marlin.sqlite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Marlin.sqlite.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230501122929_Barcodes")]
    partial class Barcodes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("Marlin.sqlite.Models.AccessProfiles", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfileID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfileName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("AccessProfiles");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.AccessSettings", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccessObject")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Grant")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfileID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("AccessSettings");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.AccountSettings", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BillingSettings")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BuyerWS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SupplierWS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("AccountSettings");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.Accounts", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Buyer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LegalCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Supplier")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.Catalogues", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastChangeDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SourceCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Catalogues");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.ConnectionSettings", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("AsBuyer")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AsSupplier")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConnectedAccountID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ConnectionStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PriceTypes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("ConnectionSettings");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.ErrorCodes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("ErrorCodes");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.ExchangeLog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("ErrorCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MessageID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TransactionID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("ExchangeLog");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.InvoiceDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<string>("InvoiceID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("ProductID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Quantity")
                        .HasColumnType("REAL");

                    b.Property<double>("Unit")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.ToTable("InvoiceDetails");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.InvoiceHeader", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("InvoiceID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Number")
                        .HasColumnType("REAL");

                    b.Property<string>("OrderID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("StatusID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WaybillNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("InvoiceHeaders");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.Invoices", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Package")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Period")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.Messages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("JSONBody")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MessageID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReceiverID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SenderID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<string>("OrderID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("ProductID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Quantity")
                        .HasColumnType("REAL");

                    b.Property<double>("ReservedQuantity")
                        .HasColumnType("REAL");

                    b.Property<double>("Unit")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.OrderHeaders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReceiverID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SenderID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShopID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SourceID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("StatusID")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("OrderHeaders");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("StatusID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.OrderStatusHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StatusID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("OrderStatusHistory");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.PositionName", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PriceTypeID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("PositionName");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.PriceList", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("PriceType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Unit")
                        .HasColumnType("REAL");

                    b.HasKey("ID");

                    b.ToTable("PriceList");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.ProductsByCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ProductsByCategories");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.Shops", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GPS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShopID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SourceCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.UserPositions", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PositionID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("UserPositions");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.UserSettings", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProfileID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("UserSettings");
                });

            modelBuilder.Entity("Marlin.sqlite.Models.Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PositionInCompany")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
