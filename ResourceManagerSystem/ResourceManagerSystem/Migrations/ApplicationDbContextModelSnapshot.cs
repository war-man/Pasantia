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

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("RegionID");

                    b.HasKey("AdministrativeID");

                    b.HasIndex("RegionID");

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
                    b.Property<int>("CollectionREPPID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OperativeID");

                    b.Property<int>("ReppID");

                    b.HasKey("CollectionREPPID");

                    b.HasIndex("OperativeID");

                    b.HasIndex("ReppID");

                    b.ToTable("CollectionsREPP");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Color", b =>
                {
                    b.Property<string>("ColorName");

                    b.HasKey("ColorName");

                    b.ToTable("Color");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Phone");

                    b.HasKey("ContactID");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Contrat", b =>
                {
                    b.Property<int>("ContratID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AdministrativeID");

                    b.Property<string>("CI");

                    b.Property<DateTime>("DateEnd");

                    b.Property<DateTime>("DateStart");

                    b.Property<int>("OperativeID");

                    b.Property<int>("TypeContrat");

                    b.HasKey("ContratID");

                    b.HasIndex("AdministrativeID");

                    b.HasIndex("CI");

                    b.HasIndex("OperativeID");

                    b.ToTable("Contrat");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttendanceType");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("DurationWeek");

                    b.Property<bool>("IsExternal");

                    b.Property<bool>("IsRequired");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("OrganizingEntityID");

                    b.HasKey("CourseID");

                    b.HasIndex("OrganizingEntityID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Delivery", b =>
                {
                    b.Property<int>("DeliveryID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<string>("Description");

                    b.Property<string>("LotID");

                    b.Property<int>("Quantity");

                    b.Property<int>("ReppID");

                    b.HasKey("DeliveryID");

                    b.HasIndex("LotID");

                    b.HasIndex("ReppID");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.DeliveryModelView", b =>
                {
                    b.Property<int>("DeliveryModelViewID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand")
                        .IsRequired();

                    b.Property<string>("ColorName");

                    b.Property<string>("Description");

                    b.Property<string>("LotID");

                    b.Property<int>("Quantity");

                    b.Property<int>("ReppID");

                    b.Property<string>("SizeName");

                    b.HasKey("DeliveryModelViewID");

                    b.HasIndex("ColorName");

                    b.HasIndex("ReppID");

                    b.HasIndex("SizeName");

                    b.ToTable("DeliveryModelView");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Employee", b =>
                {
                    b.Property<string>("CI");

                    b.Property<DateTime>("AdmissionDate");

                    b.Property<bool>("Basic");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("CivilState");

                    b.Property<bool>("Degree");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int>("Height");

                    b.Property<bool>("HighSchool");

                    b.Property<bool>("Illiterate");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("Mental");

                    b.Property<bool>("MiddleTechnician");

                    b.Property<bool>("Motor");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("OperativeID");

                    b.Property<int>("Phone");

                    b.Property<int>("Sex");

                    b.Property<bool>("Visual");

                    b.Property<int>("Weight");

                    b.HasKey("CI");

                    b.HasIndex("OperativeID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.EmployeModelView", b =>
                {
                    b.Property<string>("CI");

                    b.Property<DateTime>("AdmissionDate");

                    b.Property<bool>("Basic");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("CivilState");

                    b.Property<DateTime>("DateEnd");

                    b.Property<DateTime>("DateStart");

                    b.Property<bool>("Degree");

                    b.Property<string>("Email");

                    b.Property<string>("EmployeeCI");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int>("Height");

                    b.Property<bool>("HighSchool");

                    b.Property<bool>("Illiterate");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("Mental");

                    b.Property<bool>("MiddleTechnician");

                    b.Property<bool>("Motor");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("OperativeID");

                    b.Property<int>("Phone");

                    b.Property<int>("Sex");

                    b.Property<int>("TypeContrat");

                    b.Property<bool>("Visual");

                    b.Property<int>("Weight");

                    b.HasKey("CI");

                    b.HasIndex("EmployeeCI");

                    b.HasIndex("OperativeID");

                    b.ToTable("EmployeModelView");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Enrolment", b =>
                {
                    b.Property<int>("CourseID");

                    b.Property<int>("CI");

                    b.Property<DateTime>("Date");

                    b.Property<string>("EmployeeCI");

                    b.HasKey("CourseID", "CI");

                    b.HasAlternateKey("CI", "CourseID");

                    b.HasIndex("EmployeeCI");

                    b.ToTable("Enrolment");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Lot", b =>
                {
                    b.Property<string>("LotID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("ProviderID");

                    b.HasKey("LotID");

                    b.HasIndex("ProviderID");

                    b.ToTable("Lot");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Operative", b =>
                {
                    b.Property<int>("OperativeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("OperativeID");

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

            modelBuilder.Entity("ResourceManagerSystem.Models.Provider", b =>
                {
                    b.Property<int>("ProviderID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<int>("ContactID");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ProviderID");

                    b.HasIndex("ContactID")
                        .IsUnique();

                    b.ToTable("Provider");
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

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ReppID");

                    b.ToTable("REPPS");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Size", b =>
                {
                    b.Property<string>("SizeName");

                    b.HasKey("SizeName");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Stock", b =>
                {
                    b.Property<int>("StockID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ColorName");

                    b.Property<int>("Quantity");

                    b.Property<int>("ReppID");

                    b.Property<string>("SizeName");

                    b.HasKey("StockID");

                    b.HasIndex("ColorName");

                    b.HasIndex("ReppID");

                    b.HasIndex("SizeName");

                    b.ToTable("Stock");
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

            modelBuilder.Entity("ResourceManagerSystem.Models.Administrative", b =>
                {
                    b.HasOne("ResourceManagerSystem.Models.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.CollectionREPP", b =>
                {
                    b.HasOne("ResourceManagerSystem.Models.Operative", "Operative")
                        .WithMany("CollectionRepp")
                        .HasForeignKey("OperativeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ResourceManagerSystem.Models.REPP", "REEP")
                        .WithMany()
                        .HasForeignKey("ReppID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Contrat", b =>
                {
                    b.HasOne("ResourceManagerSystem.Models.Administrative", "Administrative")
                        .WithMany()
                        .HasForeignKey("AdministrativeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ResourceManagerSystem.Models.Employee", "Employee")
                        .WithMany("Contrats")
                        .HasForeignKey("CI");

                    b.HasOne("ResourceManagerSystem.Models.Operative", "Operative")
                        .WithMany()
                        .HasForeignKey("OperativeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Course", b =>
                {
                    b.HasOne("ResourceManagerSystem.Models.OrganizingEntity", "OrganizingEntity")
                        .WithMany()
                        .HasForeignKey("OrganizingEntityID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Delivery", b =>
                {
                    b.HasOne("ResourceManagerSystem.Models.Lot", "Lot")
                        .WithMany("Delivery")
                        .HasForeignKey("LotID");

                    b.HasOne("ResourceManagerSystem.Models.REPP", "Reep")
                        .WithMany()
                        .HasForeignKey("ReppID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.DeliveryModelView", b =>
                {
                    b.HasOne("ResourceManagerSystem.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorName");

                    b.HasOne("ResourceManagerSystem.Models.REPP", "Repp")
                        .WithMany()
                        .HasForeignKey("ReppID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ResourceManagerSystem.Models.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeName");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Employee", b =>
                {
                    b.HasOne("ResourceManagerSystem.Models.Operative")
                        .WithMany("Employee")
                        .HasForeignKey("OperativeID");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.EmployeModelView", b =>
                {
                    b.HasOne("ResourceManagerSystem.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeCI");

                    b.HasOne("ResourceManagerSystem.Models.Operative", "Position")
                        .WithMany()
                        .HasForeignKey("OperativeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Enrolment", b =>
                {
                    b.HasOne("ResourceManagerSystem.Models.Course", "Courses")
                        .WithMany("Enrolments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ResourceManagerSystem.Models.Employee", "Employee")
                        .WithMany("Enrolment")
                        .HasForeignKey("EmployeeCI");
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Lot", b =>
                {
                    b.HasOne("ResourceManagerSystem.Models.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Provider", b =>
                {
                    b.HasOne("ResourceManagerSystem.Models.Contact", "Contact")
                        .WithOne("Provider")
                        .HasForeignKey("ResourceManagerSystem.Models.Provider", "ContactID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ResourceManagerSystem.Models.Stock", b =>
                {
                    b.HasOne("ResourceManagerSystem.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorName");

                    b.HasOne("ResourceManagerSystem.Models.REPP", "Repp")
                        .WithMany()
                        .HasForeignKey("ReppID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ResourceManagerSystem.Models.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeName");
                });
#pragma warning restore 612, 618
        }
    }
}
