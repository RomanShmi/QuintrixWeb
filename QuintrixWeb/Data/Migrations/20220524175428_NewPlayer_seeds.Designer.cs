﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuintrixWeb.Data;

#nullable disable

namespace QuintrixWeb.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220524175428_NewPlayer_seeds")]
    partial class NewPlayer_seeds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("QuintrixWeb.Models.NewPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("NewPlayers");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            Email = "seed1@seed.ss",
                            Level = 7,
                            Name = "Seed1",
                            StateId = 8
                        },
                        new
                        {
                            Id = 6,
                            Email = "seed2@seed.ss",
                            Level = 7,
                            Name = "Seed2",
                            StateId = 12
                        },
                        new
                        {
                            Id = 7,
                            Email = "seed3@seed.ss",
                            Level = 9,
                            Name = "Seed3",
                            StateId = 23
                        });
                });

            modelBuilder.Entity("QuintrixWeb.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("State");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Abbreviation = "AL",
                            Name = "Alabama"
                        },
                        new
                        {
                            Id = 2,
                            Abbreviation = "AK",
                            Name = "Alaska"
                        },
                        new
                        {
                            Id = 3,
                            Abbreviation = "AZ",
                            Name = "Arizona"
                        },
                        new
                        {
                            Id = 4,
                            Abbreviation = "AR",
                            Name = "Arkansas"
                        },
                        new
                        {
                            Id = 5,
                            Abbreviation = "CA",
                            Name = "California"
                        },
                        new
                        {
                            Id = 6,
                            Abbreviation = "CO",
                            Name = "Colorado"
                        },
                        new
                        {
                            Id = 7,
                            Abbreviation = "CT",
                            Name = "Connecticut"
                        },
                        new
                        {
                            Id = 8,
                            Abbreviation = "DE",
                            Name = "Delaware"
                        },
                        new
                        {
                            Id = 9,
                            Abbreviation = "DC",
                            Name = "District of Columbia"
                        },
                        new
                        {
                            Id = 10,
                            Abbreviation = "FL",
                            Name = "Florida"
                        },
                        new
                        {
                            Id = 11,
                            Abbreviation = "GA",
                            Name = "Georgia"
                        },
                        new
                        {
                            Id = 12,
                            Abbreviation = "HI",
                            Name = "Hawaii"
                        },
                        new
                        {
                            Id = 13,
                            Abbreviation = "ID",
                            Name = "Idaho"
                        },
                        new
                        {
                            Id = 14,
                            Abbreviation = "IL",
                            Name = "Illinois"
                        },
                        new
                        {
                            Id = 15,
                            Abbreviation = "IN",
                            Name = "Indiana"
                        },
                        new
                        {
                            Id = 16,
                            Abbreviation = "IA",
                            Name = "Iowa"
                        },
                        new
                        {
                            Id = 17,
                            Abbreviation = "KS",
                            Name = "Kansas"
                        },
                        new
                        {
                            Id = 18,
                            Abbreviation = "KY",
                            Name = "Kentucky"
                        },
                        new
                        {
                            Id = 19,
                            Abbreviation = "LA",
                            Name = "Louisiana"
                        },
                        new
                        {
                            Id = 20,
                            Abbreviation = "ME",
                            Name = "Maine"
                        },
                        new
                        {
                            Id = 21,
                            Abbreviation = "MD",
                            Name = "Maryland"
                        },
                        new
                        {
                            Id = 22,
                            Abbreviation = "MS",
                            Name = "Massachusetts"
                        },
                        new
                        {
                            Id = 23,
                            Abbreviation = "MI",
                            Name = "Michigan"
                        },
                        new
                        {
                            Id = 24,
                            Abbreviation = "MN",
                            Name = "Minnesota"
                        },
                        new
                        {
                            Id = 25,
                            Abbreviation = "MS",
                            Name = "Mississippi"
                        },
                        new
                        {
                            Id = 26,
                            Abbreviation = "MO",
                            Name = "Missouri"
                        },
                        new
                        {
                            Id = 27,
                            Abbreviation = "MT",
                            Name = "Montana"
                        },
                        new
                        {
                            Id = 28,
                            Abbreviation = "NE",
                            Name = "Nebraska"
                        },
                        new
                        {
                            Id = 29,
                            Abbreviation = "NV",
                            Name = "Nevada"
                        },
                        new
                        {
                            Id = 30,
                            Abbreviation = "NH",
                            Name = "New Hampshire"
                        },
                        new
                        {
                            Id = 31,
                            Abbreviation = "NJ",
                            Name = "New Jersey"
                        },
                        new
                        {
                            Id = 32,
                            Abbreviation = "NM",
                            Name = "New Mexico"
                        },
                        new
                        {
                            Id = 33,
                            Abbreviation = "NY",
                            Name = "New York"
                        },
                        new
                        {
                            Id = 34,
                            Abbreviation = "NC",
                            Name = "North Carolina"
                        },
                        new
                        {
                            Id = 35,
                            Abbreviation = "ND",
                            Name = "North Dakota"
                        },
                        new
                        {
                            Id = 36,
                            Abbreviation = "OH",
                            Name = "Ohio"
                        },
                        new
                        {
                            Id = 37,
                            Abbreviation = "OK",
                            Name = "Oklahoma"
                        },
                        new
                        {
                            Id = 38,
                            Abbreviation = "OR",
                            Name = "Oregon"
                        },
                        new
                        {
                            Id = 39,
                            Abbreviation = "PA",
                            Name = "Pennsylvania"
                        },
                        new
                        {
                            Id = 40,
                            Abbreviation = "RI",
                            Name = "Rhode Island"
                        },
                        new
                        {
                            Id = 41,
                            Abbreviation = "SC",
                            Name = "South Carolina"
                        },
                        new
                        {
                            Id = 42,
                            Abbreviation = "SD",
                            Name = "South Dakota"
                        },
                        new
                        {
                            Id = 43,
                            Abbreviation = "TN",
                            Name = "Tennessee"
                        },
                        new
                        {
                            Id = 44,
                            Abbreviation = "TX",
                            Name = "Texas"
                        },
                        new
                        {
                            Id = 45,
                            Abbreviation = "UT",
                            Name = "Utah"
                        },
                        new
                        {
                            Id = 46,
                            Abbreviation = "VT",
                            Name = "Vermont"
                        },
                        new
                        {
                            Id = 47,
                            Abbreviation = "VA",
                            Name = "Virginia"
                        },
                        new
                        {
                            Id = 48,
                            Abbreviation = "WA",
                            Name = "Washington"
                        },
                        new
                        {
                            Id = 49,
                            Abbreviation = "WV",
                            Name = "West Virginia"
                        },
                        new
                        {
                            Id = 50,
                            Abbreviation = "WI",
                            Name = "Wisconsin"
                        },
                        new
                        {
                            Id = 51,
                            Abbreviation = "WY",
                            Name = "Wyoming"
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuintrixWeb.Models.NewPlayer", b =>
                {
                    b.HasOne("QuintrixWeb.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });
#pragma warning restore 612, 618
        }
    }
}
