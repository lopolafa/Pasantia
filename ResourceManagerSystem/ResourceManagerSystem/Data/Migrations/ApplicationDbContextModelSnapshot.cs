﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ResourceManagerSystem.Data;
using ResourceManagerSystem.Models;
using System;

namespace ResourceManagerSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Administrative", b =>
                {
                    b.Property<int>("AdministrativeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("AdministrativeID");

                    b.ToTable("Administrative");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.CollectionREPP", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OperativeID");

                    b.Property<int>("ReppID");

                    b.HasKey("ID");

                    b.HasIndex("OperativeID");

                    b.HasIndex("ReppID");

                    b.ToTable("CollectionsREPP");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Employee", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AdmissionDate");

                    b.Property<bool>("Basic");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("Ci");

                    b.Property<int>("CivilState");

                    b.Property<bool>("Degree");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<int>("Height");

                    b.Property<bool>("HighSchool");

                    b.Property<bool>("HighTechnician");

                    b.Property<bool>("Iliterate");

                    b.Property<string>("LastName");

                    b.Property<bool>("Mental");

                    b.Property<bool>("MiddleTechnician");

                    b.Property<bool>("Motor");

                    b.Property<string>("Name");

                    b.Property<int>("OperativeID");

                    b.Property<int>("Phone");

                    b.Property<int>("Sex");

                    b.Property<int>("TypeContrat");

                    b.Property<bool>("Visual");

                    b.Property<int>("Weight");

                    b.HasKey("PersonID");

                    b.HasIndex("OperativeID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Operative", b =>
                {
                    b.Property<int>("OperativeID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AdministrativeID");

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.Property<int>("RegionID");

                    b.HasKey("OperativeID");

                    b.HasIndex("AdministrativeID");

                    b.HasIndex("RegionID");

                    b.ToTable("Operative");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.OrganizingEntity", b =>
                {
                    b.Property<int>("OrganizingEntityID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("TypeOfEntity");

                    b.HasKey("OrganizingEntityID");

                    b.ToTable("OrganizingEntity");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Region", b =>
                {
                    b.Property<int>("RegionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("RegionID");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.REPP", b =>
                {
                    b.Property<int>("ReppID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand")
                        .IsRequired();

                    b.Property<int>("Color");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Size");

                    b.HasKey("ReppID");

                    b.ToTable("REPPS");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ResourceManagerSystem.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ResourceManagerSystem.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ResourceManagerSystem.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ResourceManagerSystem.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.CollectionREPP", b =>
                {
                    b.HasOne("ResourceManagerSystem.Models.Operative", "Operative")
                        .WithMany("CollectionRepp")
                        .HasForeignKey("OperativeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ResourceManagerSystem.Models.REPP", "REEP")
                        .WithMany("CollectionsREPPs")
                        .HasForeignKey("ReppID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Employee", b =>
                {
                    b.HasOne("ResourceManagerSystem.Models.Operative", "Position")
                        .WithMany()
                        .HasForeignKey("OperativeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Operative", b =>
                {
                    b.HasOne("ResourceManagerSystem.Models.Administrative", "Administrative")
                        .WithMany()
                        .HasForeignKey("AdministrativeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ResourceManagerSystem.Models.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
