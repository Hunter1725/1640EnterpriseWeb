﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnterpriseWeb.Migrations
{
    [DbContext(typeof(EnterpriseWebContext))]
    partial class EnterpriseWebContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EnterpriseWeb.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AcademicYear")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ClousureDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FinalDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ClosureDate");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CommentText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdeaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubmitDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdeaId");

                    b.HasIndex("UserId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClosureDateID")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SubmissionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SupportingDocuments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClosureDateID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("UserID");

                    b.ToTable("Idea");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.IdeaCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("QACoordinator");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdeaID")
                        .HasColumnType("int");

                    b.Property<int>("RatingValue")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubmitionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdeaID");

                    b.HasIndex("UserId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.Comment", b =>
                {
                    b.HasOne("EnterpriseWeb.Models.Idea", "Idea")
                        .WithMany("Comments")
                        .HasForeignKey("IdeaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnterpriseWeb.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Idea");

                    b.Navigation("User");
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

                    b.HasOne("EnterpriseWeb.Models.User", "User")
                        .WithMany("Ideas")
                        .HasForeignKey("UserID");

                    b.Navigation("ClosureDate");

                    b.Navigation("Department");

                    b.Navigation("User");
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

                    b.HasOne("EnterpriseWeb.Models.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Idea");

                    b.Navigation("User");
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
                });

            modelBuilder.Entity("EnterpriseWeb.Models.QACoordinator", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("EnterpriseWeb.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Ideas");

                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
