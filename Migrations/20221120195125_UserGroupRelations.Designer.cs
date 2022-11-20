﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapiSBIFS.Model;

#nullable disable

namespace webapiSBIFS.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221120195125_UserGroupRelations")]
    partial class UserGroupRelations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GroupUser", b =>
                {
                    b.Property<int>("GroupsGroupID")
                        .HasColumnType("int");

                    b.Property<int>("ParticipantsUserID")
                        .HasColumnType("int");

                    b.HasKey("GroupsGroupID", "ParticipantsUserID");

                    b.HasIndex("ParticipantsUserID");

                    b.ToTable("GroupUser");
                });

            modelBuilder.Entity("webapiSBIFS.Model.Group", b =>
                {
                    b.Property<int>("GroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupID"));

                    b.Property<int>("OwnerID")
                        .HasColumnType("int");

                    b.HasKey("GroupID");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("webapiSBIFS.Model.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Privilege")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GroupUser", b =>
                {
                    b.HasOne("webapiSBIFS.Model.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupsGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapiSBIFS.Model.User", null)
                        .WithMany()
                        .HasForeignKey("ParticipantsUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}