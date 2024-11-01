﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vallet.Persistence.Contexts;

#nullable disable

namespace Vallet.Persistence.Migrations
{
    [DbContext(typeof(ValletDbContext))]
    [Migration("20241101085642_mig1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Vallet.Domain.Entities.Concretes.Blok", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BlockName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BlockNumberOfFloors")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("SiteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.ToTable("Bloks");
                });

            modelBuilder.Entity("Vallet.Domain.Entities.Concretes.Daire", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BlockId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DaireApartmentNumber")
                        .HasColumnType("int");

                    b.Property<int>("DaireFloorNumber")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<Guid?>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BlockId");

                    b.HasIndex("UsersId");

                    b.ToTable("Daires");
                });

            modelBuilder.Entity("Vallet.Domain.Entities.Concretes.DaireBorc", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DaireId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DebtAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DebtCreatedByAdminId")
                        .HasColumnType("int");

                    b.Property<string>("DebtDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DebtDueDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DaireId");

                    b.HasIndex("UsersId");

                    b.ToTable("DaireBorcs");
                });

            modelBuilder.Entity("Vallet.Domain.Entities.Concretes.Site", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SiteAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SiteIsApartment")
                        .HasColumnType("bit");

                    b.Property<string>("SiteName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("Vallet.Domain.Entities.Concretes.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Vallet.Domain.Entities.Concretes.Blok", b =>
                {
                    b.HasOne("Vallet.Domain.Entities.Concretes.Site", null)
                        .WithMany("Blocks")
                        .HasForeignKey("SiteId");
                });

            modelBuilder.Entity("Vallet.Domain.Entities.Concretes.Daire", b =>
                {
                    b.HasOne("Vallet.Domain.Entities.Concretes.Blok", "Block")
                        .WithMany("Daires")
                        .HasForeignKey("BlockId");

                    b.HasOne("Vallet.Domain.Entities.Concretes.User", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId");

                    b.Navigation("Block");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Vallet.Domain.Entities.Concretes.DaireBorc", b =>
                {
                    b.HasOne("Vallet.Domain.Entities.Concretes.Daire", "Daire")
                        .WithMany("DaireBorcs")
                        .HasForeignKey("DaireId");

                    b.HasOne("Vallet.Domain.Entities.Concretes.User", "Users")
                        .WithMany("CreatedBorclar")
                        .HasForeignKey("UsersId");

                    b.Navigation("Daire");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Vallet.Domain.Entities.Concretes.Blok", b =>
                {
                    b.Navigation("Daires");
                });

            modelBuilder.Entity("Vallet.Domain.Entities.Concretes.Daire", b =>
                {
                    b.Navigation("DaireBorcs");
                });

            modelBuilder.Entity("Vallet.Domain.Entities.Concretes.Site", b =>
                {
                    b.Navigation("Blocks");
                });

            modelBuilder.Entity("Vallet.Domain.Entities.Concretes.User", b =>
                {
                    b.Navigation("CreatedBorclar");
                });
#pragma warning restore 612, 618
        }
    }
}
