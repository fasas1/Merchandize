﻿// <auto-generated />
using System;
using Merchantdized.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Merchantdized.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Merchantdized.Model.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Merchantdized.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Macbook",
                            Description = "2017 Macbook Pro - Corei5 - 16gb RAM - 512gb SSD - Touchbar - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                            Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574595/Macbook_Pro_vvbq1q.png",
                            Name = "Macbook Pro",
                            Price = 380000.0
                        },
                        new
                        {
                            Id = 2,
                            Category = "Gaming PC",
                            Description = "Asus ROG Strix G713M - 32gb RAM - 1tb SSD - Ryzen 7 - 11th Generation - RGB Backlit - 6gb Nvidia RTX 3060 - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                            Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574594/Asus_ROG_owaj4r.png",
                            Name = "Asus ROG",
                            Price = 760000.0
                        },
                        new
                        {
                            Id = 3,
                            Category = "Iphone",
                            Description = "Iphoe 13Pro - 512gb Storage - Factory Unlock - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                            Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574592/Iphone_13_Promax_i8mop8.png",
                            Name = "Iphone 13Pro",
                            Price = 420000.0
                        },
                        new
                        {
                            Id = 4,
                            Category = "Gaming PC",
                            Description = "Alienware M15 R7 - 16gb RAM - 512gb SSD - 10th Generation - 6gb Nvidia RTX 2080 - RGB Backlit - Factory Unlock - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                            Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574591/Alienware_ijwzbh.png",
                            Name = "Alienware M15",
                            Price = 530000.0
                        },
                        new
                        {
                            Id = 5,
                            Category = "Iwatch",
                            Description = "Iwatch Series 7 - 44MM - GPS and Cellular - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                            Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574593/iwatch_i9c7sp.png",
                            Name = "Iwatch",
                            Price = 240000.0
                        },
                        new
                        {
                            Id = 6,
                            Category = "Gaming PC",
                            Description = "Pavillion 15 - 16gb RAM - 512gb SSD - 4gb Nvidia GTX 1060 - 9th Generation - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                            Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574591/HP_Pavillion_nyey1g.png",
                            Name = "HP Pavillion",
                            Price = 360000.0
                        },
                        new
                        {
                            Id = 7,
                            Category = "Laptop",
                            Description = "HP Elitebook 1030 G2 - Corei5 - 16gb RAM - 25gbg SSD - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                            Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574591/HP_14_tohtif.png",
                            Name = "HP Elitebook",
                            Price = 250000.0
                        },
                        new
                        {
                            Id = 8,
                            Category = "Iphone",
                            Description = "Iphone 14 - 512gb Storage - Factory Unlock - Pacific Blue Color - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                            Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574593/Iphone_14_bwnejg.png",
                            Name = "Iphone 14",
                            Price = 560000.0
                        },
                        new
                        {
                            Id = 9,
                            Category = "Gaming PC",
                            Description = "Dell G7 Gaming Laptop - Corei7 - 16gb RAM - 512gb SSD - 6gb Nvidia RTX 2070 - 10th Generation - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                            Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574591/Dell_G7_r9ugk7.png",
                            Name = "Dell G7",
                            Price = 485000.0
                        },
                        new
                        {
                            Id = 10,
                            Category = "Macbook",
                            Description = "2019 Macbook Pro - 16gb RAM - 512gb SSD - Touchbar - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                            Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574593/Mabook_Pro_aicpdz.png",
                            Name = "Macbook Pro",
                            Price = 455000.0
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Merchantdized.Model.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Merchantdized.Model.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Merchantdized.Model.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Merchantdized.Model.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
