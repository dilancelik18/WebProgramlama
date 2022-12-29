﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentCar.Models.Siniflar;

#nullable disable

namespace RentCar.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221228100352_m8")]
    partial class m8
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RentCar.Models.Siniflar.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Kullanici")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("admins");
                });

            modelBuilder.Entity("RentCar.Models.Siniflar.Arac", b =>
                {
                    b.Property<int>("AracId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AracId"));

                    b.Property<string>("aracModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("besgünFiyat")
                        .HasColumnType("int");

                    b.Property<int>("fotoUrl")
                        .HasColumnType("int");

                    b.Property<int>("onbesgünFiyat")
                        .HasColumnType("int");

                    b.Property<int>("otuzgünFiyat")
                        .HasColumnType("int");

                    b.HasKey("AracId");

                    b.ToTable("aracs");
                });

            modelBuilder.Entity("RentCar.Models.Siniflar.Uye", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YorumId")
                        .HasColumnType("int");

                    b.Property<string>("eMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("YorumId");

                    b.ToTable("uye");
                });

            modelBuilder.Entity("RentCar.Models.Siniflar.Yorum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AracId")
                        .HasColumnType("int");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("yorum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AracId");

                    b.ToTable("yorum");
                });

            modelBuilder.Entity("RentCar.Models.Siniflar.Uye", b =>
                {
                    b.HasOne("RentCar.Models.Siniflar.Yorum", "Yorum")
                        .WithMany("uye")
                        .HasForeignKey("YorumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yorum");
                });

            modelBuilder.Entity("RentCar.Models.Siniflar.Yorum", b =>
                {
                    b.HasOne("RentCar.Models.Siniflar.Arac", "Arac")
                        .WithMany("Yorums")
                        .HasForeignKey("AracId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Arac");
                });

            modelBuilder.Entity("RentCar.Models.Siniflar.Arac", b =>
                {
                    b.Navigation("Yorums");
                });

            modelBuilder.Entity("RentCar.Models.Siniflar.Yorum", b =>
                {
                    b.Navigation("uye");
                });
#pragma warning restore 612, 618
        }
    }
}
