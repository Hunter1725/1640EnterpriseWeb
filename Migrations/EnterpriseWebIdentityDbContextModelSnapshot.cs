﻿// <auto-generated />
using System;
using EnterpriseWeb.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnterpriseWeb.Migrations
{
    [DbContext(typeof(EnterpriseWebIdentityDbContext))]
    partial class EnterpriseWebIdentityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EnterpriseWeb.Areas.Identity.Data.IdeaUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

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

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(max)");

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

            modelBuilder.Entity("EnterpriseWeb.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.ClosureDate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AcademicYear")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ClousureDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FinalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ClosureDate");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CommentText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdeaId")
                        .HasColumnType("int");

                    b.Property<string>("IdeaUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("SubmitDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdeaId");

                    b.HasIndex("IdeaUserId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QACoordinatorID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QACoordinatorID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.Idea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ClosureDateID")
                        .HasColumnType("int");

                    b.Property<byte[]>("DataFiles")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdeaUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("SubmissionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SupportingDocuments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClosureDateID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("IdeaUserId");

                    b.ToTable("Idea");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.IdeaCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int?>("IdeaID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.HasIndex("IdeaID");

                    b.ToTable("IdeaCategory");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.QACoordinator", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("QACoordinator");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdeaID")
                        .HasColumnType("int");

                    b.Property<string>("IdeaUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RatingDown")
                        .HasColumnType("int");

                    b.Property<int>("RatingUp")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubmitionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdeaID");

                    b.HasIndex("IdeaUserId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.Viewing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Count")
                        .HasColumnType("int");

                    b.Property<int>("IdeaId")
                        .HasColumnType("int");

                    b.Property<string>("IdeaUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ViewDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdeaId");

                    b.HasIndex("IdeaUserId");

                    b.ToTable("Viewing");
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

            modelBuilder.Entity("EnterpriseWeb.Models.Comment", b =>
                {
                    b.HasOne("EnterpriseWeb.Models.Idea", "Idea")
                        .WithMany("Comments")
                        .HasForeignKey("IdeaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnterpriseWeb.Areas.Identity.Data.IdeaUser", "IdeaUser")
                        .WithMany("Comments")
                        .HasForeignKey("IdeaUserId");

                    b.Navigation("Idea");

                    b.Navigation("IdeaUser");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.Department", b =>
                {
                    b.HasOne("EnterpriseWeb.Models.QACoordinator", "QACoordinator")
                        .WithMany("Departments")
                        .HasForeignKey("QACoordinatorID");

                    b.Navigation("QACoordinator");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.Idea", b =>
                {
                    b.HasOne("EnterpriseWeb.Models.ClosureDate", "ClosureDate")
                        .WithMany("Ideas")
                        .HasForeignKey("ClosureDateID");

                    b.HasOne("EnterpriseWeb.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentID");

                    b.HasOne("EnterpriseWeb.Areas.Identity.Data.IdeaUser", "IdeaUser")
                        .WithMany("Ideas")
                        .HasForeignKey("IdeaUserId");

                    b.Navigation("ClosureDate");

                    b.Navigation("Department");

                    b.Navigation("IdeaUser");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.IdeaCategory", b =>
                {
                    b.HasOne("EnterpriseWeb.Models.Category", "Category")
                        .WithMany("IdeaCategories")
                        .HasForeignKey("CategoryID");

                    b.HasOne("EnterpriseWeb.Models.Idea", "Idea")
                        .WithMany("IdeaCategories")
                        .HasForeignKey("IdeaID");

                    b.Navigation("Category");

                    b.Navigation("Idea");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.Rating", b =>
                {
                    b.HasOne("EnterpriseWeb.Models.Idea", "Idea")
                        .WithMany("Ratings")
                        .HasForeignKey("IdeaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnterpriseWeb.Areas.Identity.Data.IdeaUser", "IdeaUser")
                        .WithMany("Ratings")
                        .HasForeignKey("IdeaUserId");

                    b.Navigation("Idea");

                    b.Navigation("IdeaUser");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.Viewing", b =>
                {
                    b.HasOne("EnterpriseWeb.Models.Idea", "Idea")
                        .WithMany("Viewings")
                        .HasForeignKey("IdeaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnterpriseWeb.Areas.Identity.Data.IdeaUser", "IdeaUser")
                        .WithMany("Viewings")
                        .HasForeignKey("IdeaUserId");

                    b.Navigation("Idea");

                    b.Navigation("IdeaUser");
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
                    b.HasOne("EnterpriseWeb.Areas.Identity.Data.IdeaUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EnterpriseWeb.Areas.Identity.Data.IdeaUser", null)
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

                    b.HasOne("EnterpriseWeb.Areas.Identity.Data.IdeaUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EnterpriseWeb.Areas.Identity.Data.IdeaUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnterpriseWeb.Areas.Identity.Data.IdeaUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Ideas");

                    b.Navigation("Ratings");

                    b.Navigation("Viewings");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.Category", b =>
                {
                    b.Navigation("IdeaCategories");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.ClosureDate", b =>
                {
                    b.Navigation("Ideas");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.Idea", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("IdeaCategories");

                    b.Navigation("Ratings");

                    b.Navigation("Viewings");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.QACoordinator", b =>
                {
                    b.Navigation("Departments");
                });
#pragma warning restore 612, 618
        }
    }
}
