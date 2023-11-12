﻿// <auto-generated />
using System;
using Inivohacks.DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inivohacks.DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Inivohacks.DAL.Models.CertPermission", b =>
                {
                    b.Property<int>("CertPermissionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CertPermissionID"));

                    b.Property<int>("CertificateID")
                        .HasColumnType("int");

                    b.Property<int>("PermissionID")
                        .HasColumnType("int");

                    b.HasKey("CertPermissionID");

                    b.HasIndex("CertificateID");

                    b.HasIndex("PermissionID");

                    b.ToTable("CertPermissions");
                });

            modelBuilder.Entity("Inivohacks.DAL.Models.Certificate", b =>
                {
                    b.Property<int>("CertificationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CertificationID"));

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("InUse")
                        .HasColumnType("bit");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("CertificationID");

                    b.HasIndex("ProductID");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("Inivohacks.DAL.Models.Manufacturer", b =>
                {
                    b.Property<int>("ManufacturerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ManufacturerID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotifyEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotifySMS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ManufacturerID");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("Inivohacks.DAL.Models.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PermissionId"));

                    b.Property<string>("PermissionCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermissionDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PermissionId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Inivohacks.DAL.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<string>("Dosage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManufactureID")
                        .HasColumnType("int");

                    b.Property<int>("ManufacturerID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductID");

                    b.HasIndex("ManufacturerID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Inivohacks.DAL.Models.Scan", b =>
                {
                    b.Property<Guid>("ScanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("CertificateCertificationID")
                        .HasColumnType("int");

                    b.Property<int>("CertificateID")
                        .HasColumnType("int");

                    b.Property<int>("InteractionDescription")
                        .HasColumnType("int");

                    b.Property<string>("InteractionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TrackingCodeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int?>("UserID1")
                        .HasColumnType("int");

                    b.HasKey("ScanID");

                    b.HasIndex("CertificateCertificationID");

                    b.HasIndex("CertificateID");

                    b.HasIndex("TrackingCodeID");

                    b.HasIndex("UserID");

                    b.HasIndex("UserID1");

                    b.ToTable("Scans");
                });

            modelBuilder.Entity("Inivohacks.DAL.Models.TrackingCode", b =>
                {
                    b.Property<Guid>("TrackingCodeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BatchNumber")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<bool>("RecallStatus")
                        .HasColumnType("bit");

                    b.Property<int>("SerialNumber")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrackingCodeID");

                    b.HasIndex("ProductID");

                    b.ToTable("TrackingCodes");
                });

            modelBuilder.Entity("Inivohacks.DAL.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<bool>("LoginDisabled")
                        .HasColumnType("bit");

                    b.Property<int>("ManufacturerID")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.HasIndex("ManufacturerID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Inivohacks.DAL.Models.CertPermission", b =>
                {
                    b.HasOne("Inivohacks.DAL.Models.Certificate", "Certificate")
                        .WithMany("CertPermissions")
                        .HasForeignKey("CertificateID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inivohacks.DAL.Models.Permission", "Permission")
                        .WithMany("CertPermissions")
                        .HasForeignKey("PermissionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Certificate");

                    b.Navigation("Permission");
                });

            modelBuilder.Entity("Inivohacks.DAL.Models.Certificate", b =>
                {
                    b.HasOne("Inivohacks.DAL.Models.Product", "Product")
                        .WithMany("Certificates")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Inivohacks.DAL.Models.Product", b =>
                {
                    b.HasOne("Inivohacks.DAL.Models.Manufacturer", "Manufacturer")
                        .WithMany("Products")
                        .HasForeignKey("ManufacturerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("Inivohacks.DAL.Models.Scan", b =>
                {
                    b.HasOne("Inivohacks.DAL.Models.Certificate", null)
                        .WithMany("Scans")
                        .HasForeignKey("CertificateCertificationID");

                    b.HasOne("Inivohacks.DAL.Models.Certificate", "Certificate")
                        .WithMany()
                        .HasForeignKey("CertificateID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Inivohacks.DAL.Models.TrackingCode", "TrackingCode")
                        .WithMany("Scans")
                        .HasForeignKey("TrackingCodeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inivohacks.DAL.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Inivohacks.DAL.Models.User", null)
                        .WithMany("Scans")
                        .HasForeignKey("UserID1");

                    b.Navigation("Certificate");

                    b.Navigation("TrackingCode");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Inivohacks.DAL.Models.TrackingCode", b =>
                {
                    b.HasOne("Inivohacks.DAL.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("Inivohacks.DAL.Models.User", b =>
                {
                    b.HasOne("Inivohacks.DAL.Models.Manufacturer", "Manufacturer")
                        .WithMany("Users")
                        .HasForeignKey("ManufacturerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("Inivohacks.DAL.Models.Certificate", b =>
                {
                    b.Navigation("CertPermissions");

                    b.Navigation("Scans");
                });

            modelBuilder.Entity("Inivohacks.DAL.Models.Manufacturer", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Inivohacks.DAL.Models.Permission", b =>
                {
                    b.Navigation("CertPermissions");
                });

            modelBuilder.Entity("Inivohacks.DAL.Models.Product", b =>
                {
                    b.Navigation("Certificates");
                });

            modelBuilder.Entity("Inivohacks.DAL.Models.TrackingCode", b =>
                {
                    b.Navigation("Scans");
                });

            modelBuilder.Entity("Inivohacks.DAL.Models.User", b =>
                {
                    b.Navigation("Scans");
                });
#pragma warning restore 612, 618
        }
    }
}
